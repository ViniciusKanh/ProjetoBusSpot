using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Endereco;
using Classes.Transporte;
using Classes;
using BusSpot.Cadastro;

namespace BusSpot.Transporte
{
    public partial class FrmLinha : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public FrmLinha()
        {
            InitializeComponent();
        }

        private void MensagemOK(string Mensagem)
        {
            MessageBox.Show(Mensagem, "BusSpot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensagemErro(string Mensagem)
        {
            MessageBox.Show(Mensagem, "BusSpot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            this.txtNumero_Linha.Text = string.Empty;
            this.txtDescrição.Text = string.Empty;
            this.cbEmpresa.Text = string.Empty;
            this.cbPonto.Text = string.Empty;


        }

        private void Habilitar(bool valor)
        {
            this.txt_ID.ReadOnly = !valor;
            this.txtNumero_Linha.ReadOnly = !valor;


        }
        private void HabilitarBotoes()
        {
            if (this.eNovo || eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnExcluir.Enabled = true;

            }

            else
            {

                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnExcluir.Enabled = true;
            }

        }

        private void habilitarCampos()
        {
            txtNumero_Linha.Enabled = true;
            txtDescrição.Enabled = true;
            cbPonto.Enabled = true;
            cbEmpresa.Enabled= true;
            txtNumero_Linha.Focus();

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }

        private void BuscarLinha()
        {
            this.dataLista.DataSource = Linha_Business.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Linha " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = Linha_Business.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Linha " + Convert.ToString(dataLista.Rows.Count);
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNumero_Linha.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txtNumero_Linha.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");

                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Linha_Business.Inserir(txtNumero_Linha.Text.Trim(), txtDescrição.Text.Trim(), Convert.ToInt32(cbEmpresa.SelectedValue), Convert.ToInt32(cbPonto.SelectedValue));
                    }
                    else
                    {
                        Resp = Linha_Business.Editar(Convert.ToInt32(txt_ID.Text), txtNumero_Linha.Text.Trim(), txtDescrição.Text.Trim(), Convert.ToInt32(cbEmpresa.SelectedValue), Convert.ToInt32(cbPonto.SelectedValue));
                    }

                    if (Resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOK("Registro Salvo");
                        }
                        else
                        {
                            this.MensagemOK("Registro Alterado com Sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(Resp);
                    }

                    habilitarCampos();
                    this.eNovo = false;
                    this.eEditar = false;
                    this.HabilitarBotoes();
                    this.Limpar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmLinha_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqEmpresa = "select ID, Fantasia from Empresa";

            string sqlqPonto = "select ID , Tipo from Ponto order by Tipo";

            cbEmpresa.DataSource = ConexaoDB.dql(sqlqEmpresa);
            cbEmpresa.DisplayMember = "Fantasia";
            cbEmpresa.ValueMember = "ID";

            cbPonto.DataSource = ConexaoDB.dql(sqlqPonto);
            cbPonto.DisplayMember = "Tipo";
            cbPonto.ValueMember = "ID";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar esse Linha", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Linha_Business.Remover(Convert.ToInt32(Codigo));

                            if (Resp.Equals("OK"))
                            {
                                this.MensagemOK("Registro Removido com Sucesso");
                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero_Linha.Text.Equals(""))
            {

                this.MensagemErro("Selecione um Registro para Inserir");
            }
            else
            {
                habilitarCampos();
                this.eEditar = true;
                this.HabilitarBotoes();
                this.Habilitar(true);
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txt_ID.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["ID"].Value);
            this.txtNumero_Linha.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Numero"].Value);
            this.txtDescrição.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Descrição"].Value);
            this.cbEmpresa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Empresa"].Value);
            this.cbPonto.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Tipo de Parada"].Value);
        }

        private void chkk_deletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkk_deletar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarLinha();
        }
    }
}
