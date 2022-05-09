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
    public partial class FrmPonto : Form
    {

        private bool eNovo = false;
        private bool eEditar = false;
        public FrmPonto()
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
            this.txtTipoPonto.Text = string.Empty;
            this.cbParada.Text = string.Empty;


        }

        private void Habilitar(bool valor)
        {
            this.txt_ID.ReadOnly = !valor;
            this.txtTipoPonto.ReadOnly = !valor;


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
            txtTipoPonto.Enabled = true;
            cbParada.Enabled = true;
            txtTipoPonto.Focus();

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }

        private void BuscarPonto()
        {
            this.dataLista.DataSource = Ponto_Business.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Ponto " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = Ponto_Business.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Ponto " + Convert.ToString(dataLista.Rows.Count);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtTipoPonto.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txtTipoPonto.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");

                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Ponto_Business.Inserir(txtTipoPonto.Text.Trim(),Convert.ToInt32(cbParada.SelectedValue));
                    }
                    else
                    {
                        Resp = Ponto_Business.Editar(Convert.ToInt32(txt_ID.Text), txtTipoPonto.Text.Trim(), Convert.ToInt32(cbParada.SelectedValue));
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

        private void FrmPonto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqParada = "select ID, Nome from Paradas order by Nome";

            cbParada.DataSource = ConexaoDB.dql(sqlqParada);
            cbParada.DisplayMember = "Nome";
            cbParada.ValueMember = "ID";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar esse Ponto", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Ponto_Business.Remover(Convert.ToInt32(Codigo));

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
            if (this.txtTipoPonto.Text.Equals(""))
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
            this.txtTipoPonto.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Tipo de Ponto"].Value);
            this.cbParada.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Nome do Ponto"].Value);
            
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarPonto();
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
    }
}
