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
    public partial class Frm_Onibus : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public Frm_Onibus()
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
            this.txtNumOnibus.Text = string.Empty;
            this.txt_Placa.Text = string.Empty;
            this.cbAcessibilidade.Text = string.Empty;
            this.cbComodidade.Text = string.Empty;
            this.cbEmbarque.Text = string.Empty;
            this.cbPagamento.Text = string.Empty;
            this.cbEmpresa.Text = string.Empty;

        }

        private void Habilitar(bool valor)
        {
            this.txt_ID.ReadOnly = !valor;
            this.txtNumOnibus.ReadOnly = !valor;


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
            txtNumOnibus.Enabled = true;
            txt_Placa.Enabled = true;
            cbAcessibilidade.Enabled = true;
            cbComodidade.Enabled = true;
            cbEmbarque.Enabled = true;
            cbPagamento.Enabled = true;
            cbEmpresa.Enabled = true;
            txtNumOnibus.Focus();

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }

        private void BuscarOnibus()
        {
            this.dataLista.DataSource = Coletivo_Business.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Onibus " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = Coletivo_Business.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Onibus " + Convert.ToString(dataLista.Rows.Count);
        }

        private void txtFantasia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
            this.txtNumOnibus.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txtNumOnibus.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");

                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Coletivo_Business.Inserir(txtNumOnibus.Text.Trim(), txt_Placa.Text.Trim(), Convert.ToInt32(cbComodidade.SelectedValue), Convert.ToInt32(cbPagamento.SelectedValue), Convert.ToInt32(cbAcessibilidade.SelectedValue), Convert.ToInt32(cbEmbarque.SelectedValue), Convert.ToInt32(cbEmpresa.SelectedValue));
                    }
                    else
                    {
                        Resp = Coletivo_Business.Editar(Convert.ToInt32(txt_ID.Text), txtNumOnibus.Text.Trim(), txt_Placa.Text.Trim(), Convert.ToInt32(cbComodidade.SelectedValue), Convert.ToInt32(cbPagamento.SelectedValue), Convert.ToInt32(cbAcessibilidade.SelectedValue), Convert.ToInt32(cbEmbarque.SelectedValue), Convert.ToInt32(cbEmpresa.SelectedValue));
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

        private void Frm_Onibus_Load(object sender, EventArgs e)
        {

            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqAcessibilidade = "select ID, tipo_acessibilidade from Acessibilidade";

            string sqlqComodidade = "select ID, Tipo_Comodidade from Comodidades";

            string sqlqEmbarque = "select ID, Tipo_Emb from Embarque";

            string sqlqPagamento = "select ID, Tipo_Pag from Pagamento";

            string sqlqEmpresa = "select ID, Fantasia from Empresa";

            cbComodidade.DataSource = ConexaoDB.dql(sqlqComodidade);
            cbComodidade.DisplayMember = "Tipo_Comodidade";
            cbComodidade.ValueMember = "ID";

            cbAcessibilidade.DataSource = ConexaoDB.dql(sqlqAcessibilidade);
            cbAcessibilidade.DisplayMember = "tipo_acessibilidade";
            cbAcessibilidade.ValueMember = "ID";

            cbPagamento.DataSource = ConexaoDB.dql(sqlqPagamento);
            cbPagamento.DisplayMember = "Tipo_Pag";
            cbPagamento.ValueMember = "ID";

            cbEmbarque.DataSource = ConexaoDB.dql(sqlqEmbarque);
            cbEmbarque.DisplayMember = "Tipo_Emb";
            cbEmbarque.ValueMember = "ID";

            cbEmpresa.DataSource = ConexaoDB.dql(sqlqEmpresa);
            cbEmpresa.DisplayMember = "Fantasia";
            cbEmpresa.ValueMember = "ID";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar esse Onibus", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Coletivo_Business.Remover(Convert.ToInt32(Codigo));

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
            if (this.txtNumOnibus.Text.Equals(""))
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

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarOnibus();
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txt_ID.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["ID"].Value);
            this.txtNumOnibus.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Numero"].Value);
            this.txt_Placa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Placa"].Value);
            this.cbComodidade.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Comodidade"].Value);
            this.cbPagamento.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Pagamento"].Value);
            this.cbAcessibilidade.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Acessibilidade"].Value);
            this.cbEmbarque.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Embarque"].Value);
            this.cbEmpresa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Empresa"].Value);

        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }
    }
}
