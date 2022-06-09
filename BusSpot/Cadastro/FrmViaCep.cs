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
using Classes;

namespace BusSpot.Cadastro
{
    public partial class FrmViaCep : Form
    {
        public FrmViaCep()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
           
            this.txtCep.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {

            this.txtCep.ReadOnly = !valor;

        }
   

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;

        }

        private void BuscarEndereco()
        {
            this.dataLista.DataSource = Endereco_Business.ViaCEP(this.txtCep.Text);
            //  this.OcultarColunas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BuscarEndereco();  
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmViaCep_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Habilitar(true);
        }
    }
}
