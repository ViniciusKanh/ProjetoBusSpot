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
    public partial class FrmEmpresa : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public FrmEmpresa()
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
            this.txt_ID.Text = string.Empty;
            this.txtFantasia.Text = string.Empty;
            this.txtCNPJ.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtSenha.Text = string.Empty;
            this.txtNumeral.Text = string.Empty;
            this.cbCEP.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.txt_ID.ReadOnly = !valor;
            this.txtCNPJ.ReadOnly = !valor;
           

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
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnExcluir.Enabled = false;
            }

        }

        private void habilitarCampos()
        {
            txtCNPJ.Enabled = true;
            txtFantasia.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            cbCEP.Enabled = true;
            btnImg.Enabled = true;
            txtNumeral.Enabled=true;
            txtCNPJ.Focus();    

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }

        private void BuscarEmpresa()
        {
            this.dataLista.DataSource = Empresa_Business.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Empresas " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = Empresa_Business.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Empresas " + Convert.ToString(dataLista.Rows.Count);
        }

        private void ttMensagem_Popup(object sender, PopupEventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar essa Empresa", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Empresa_Business.Remover(Convert.ToInt32(Codigo));

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
            if (this.txtCNPJ.Text.Equals(""))
            {

                this.MensagemErro("Selecione um Registro para Inserir");
            }
            else
            {
                this.eEditar = true;
                this.HabilitarBotoes();
                this.Habilitar(true);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txtCNPJ.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");
                    
                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Empresa_Business.Inserir(txtFantasia.Text.Trim(), txtCNPJ.Text.Trim(), Convert.ToInt32(cbCEP.SelectedValue), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), txtNumeral.Text.Trim());
                    }
                    else
                    {
                        Resp = Empresa_Business.Editar(Convert.ToInt32(txt_ID.Text), txtFantasia.Text.Trim(), txtCNPJ.Text.Trim(), Convert.ToInt32(cbCEP.SelectedValue), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), txtNumeral.Text.Trim());
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtCNPJ.Focus();
        }

        private void img_Click(object sender, EventArgs e)
        {

        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarEmpresa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txt_ID.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["ID"].Value);
            this.txtCNPJ.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["CNPJ"].Value);
            this.txtFantasia.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Fantasia"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["User"].Value);
            this.txtSenha.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Senha"].Value);
            this.cbCEP.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["CEP"].Value);
            this.txtNumeral.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Numeral"].Value);
           
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
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

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqEndereco = "select ID, CEP from Endereco order by CEP";

            cbCEP.DataSource = ConexaoDB.dql(sqlqEndereco);
            cbCEP.DisplayMember = "CEP";
            cbCEP.ValueMember = "ID";

            
        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
