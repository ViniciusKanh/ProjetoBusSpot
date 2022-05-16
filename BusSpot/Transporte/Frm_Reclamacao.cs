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
    public partial class Frm_Reclamacao : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public Frm_Reclamacao()
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
            this.txtNome.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtDescricao.Text = string.Empty;
            this.txtData.Text = string.Empty;
            this.txtRetorno.Text = string.Empty;
            this.cbEmpresa.Text = string.Empty;
            this.cbOnibus.Text = string.Empty;
            this.cbLinha.Text = string.Empty;


        }

        private void Habilitar(bool valor)
        {
            this.txt_ID.ReadOnly = !valor;
            this.txtNome.ReadOnly = !valor;


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
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtDescricao.Enabled = true;
            txtData.Enabled = true;
            txtRetorno.Enabled = true;
            cbEmpresa.Enabled = true;
            cbOnibus.Enabled = true;
            cbLinha.Enabled = true;
            txtNome.Focus();

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }

        private void BuscarReclamação()
        {
            this.dataLista.DataSource = Reclamacao_Business.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Reclamações " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = Reclamacao_Business.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Reclmações " + Convert.ToString(dataLista.Rows.Count);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Reclamacao_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Limpar();
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqEmpresa = "select ID, Fantasia from Empresa";

            string sqlqEndereco = "select ID, CEP from Endereco order by CEP";
            cbEmpresa.DataSource = ConexaoDB.dql(sqlqEmpresa);
            cbEmpresa.DisplayMember = "Fantasia";
            cbEmpresa.ValueMember = "ID";


            string sqlqOnibus = "select ID , Numero_Onibus from Onibus order by Numero_Onibus";

            string sqlqLinha = "select ID , Numero_Linha from Linha order by Numero_Linha";

            cbOnibus.DataSource = ConexaoDB.dql(sqlqOnibus);
            cbOnibus.DisplayMember = "Numero_Onibus";
            cbOnibus.ValueMember = "ID";

            cbLinha.DataSource = ConexaoDB.dql(sqlqLinha);
            cbLinha.DisplayMember = "Numero_Linha";
            cbLinha.ValueMember = "ID";
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
            this.txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txtNome.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");

                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Reclamacao_Business.Inserir(txtNome.Text, txtEmail.Text,txtTelefone.Text, txtDescricao.Text,txtData.MinDate, txtRetorno.Text, Convert.ToInt32(cbEmpresa.SelectedValue), Convert.ToInt32(cbOnibus.SelectedValue), Convert.ToInt32(cbLinha.SelectedValue));
                    }
                    else
                    {
                        Resp = Reclamacao_Business.Editar(Convert.ToInt32(txt_ID.Text), txtNome.Text, txtEmail.Text, txtTelefone.Text, txtDescricao.Text, txtData.MinDate, txtRetorno.Text, Convert.ToInt32(cbEmpresa.SelectedValue), Convert.ToInt32(cbOnibus.SelectedValue), Convert.ToInt32(cbLinha.SelectedValue));
                    }

                    if (Resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOK("Reclamação Respondida ao Usuario");
                        }
                        else
                        {
                            this.MensagemOK("Reclamação Alterado com Sucesso");
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar essa Reclamação", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Reclamacao_Business.Remover(Convert.ToInt32(Codigo));

                            if (Resp.Equals("OK"))
                            {
                                this.MensagemOK("Reclamação Removida com Sucesso");
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
            if (this.txtNome.Text.Equals(""))
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
            this.txtNome.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Nome"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Email"].Value);
            this.txtTelefone.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Telefone"].Value);
            this.txtDescricao.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Descrição"].Value);
            this.txtData.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Data da Reclamação"].Value);
            this.txtRetorno.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Reposta Empresa"].Value);
            this.cbEmpresa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Empresa"].Value);
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
            this.BuscarReclamação();
        }
    }
}
