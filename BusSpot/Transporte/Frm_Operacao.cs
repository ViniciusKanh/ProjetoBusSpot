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
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace BusSpot.Transporte
{
    public partial class Frm_Operacao : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public Frm_Operacao()
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
            this.txtData.Text = string.Empty;
            this.cbOnibus.Text = string.Empty;
            this.cbLinha.Text = string.Empty;


        }

        private void Habilitar(bool valor)
        {
            this.txt_ID.ReadOnly = !valor;
            this.txt_Buscar.ReadOnly = !valor;


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
            txtData.Enabled = true;
            cbLinha.Enabled = true;
            cbOnibus.Enabled = true;
            txtData.Focus();

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }

        private void BuscarOperacao()
        {
            this.dataLista.DataSource = Operacao_Business.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Operações " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = Operacao_Business.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Operações " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Frm_Operacao_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqOnibus = "select ID , Numero_Onibus from Onibus order by Numero_Onibus";

            string sqlqPonto = "select ID , Numero_Linha from Linha order by Numero_Linha";

            cbOnibus.DataSource = ConexaoDB.dql(sqlqOnibus);
            cbOnibus.DisplayMember = "Numero_Onibus";
            cbOnibus.ValueMember = "ID";

            cbLinha.DataSource = ConexaoDB.dql(sqlqPonto);
            cbLinha.DisplayMember = "Numero_Linha";
            cbLinha.ValueMember = "ID";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar essa Operação", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Operacao_Business.Remover(Convert.ToInt32(Codigo));

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
            if (this.txtData.Text.Equals(""))
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

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txt_ID.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["ID"].Value);
            this.txtData.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Data Operação"].Value);
            this.cbOnibus.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Onibus"].Value);
            this.cbLinha.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Linha"].Value);
                    }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtData.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txtData.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");

                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Operacao_Business.Inserir(txtData.MinDate,Convert.ToInt32(cbOnibus.SelectedValue), Convert.ToInt32(cbLinha.SelectedValue));
                    }
                    else
                    {
                        Resp = Operacao_Business.Editar(Convert.ToInt32(txt_ID.Text), txtData.MaxDate, Convert.ToInt32(cbOnibus.SelectedValue), Convert.ToInt32(cbLinha.SelectedValue));
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
            this.BuscarOperacao();
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
