namespace BusSpot
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(130, 130, 130);
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Endereco form = new Cadastro.Cadastro_Endereco();
            form.Show();
        }

        private void NovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transporte.Frm_Onibus form = new Transporte.Frm_Onibus();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transporte.FrmLinha form = new Transporte.FrmLinha();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Transporte.Frm_Reclamacao form = new Transporte.Frm_Reclamacao();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transporte.FrmParada form = new Transporte.FrmParada();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuProdutos_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuMovimentacoes_Click(object sender, EventArgs e)
        {

        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transporte.FrmLinha form = new Transporte.FrmLinha();
            form.Show();
        }

        private void novoServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void entradasESaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuReservas_Click(object sender, EventArgs e)
        {

        }

        private void novaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quadroDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuChekInOut_Click(object sender, EventArgs e)
        {

        }

        private void novoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void MenuSair_Click(object sender, EventArgs e)
        {

        }

        private void pnlTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transporte.Frm_Operacao form = new Transporte.Frm_Operacao();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transporte.Frm_Onibus form = new Transporte.Frm_Onibus();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transporte.FrmEmpresa form = new Transporte.FrmEmpresa();
            form.Show();
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Estado form = new Cadastro.Cadastro_Estado();
            form.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Cidade form = new Cadastro.Cadastro_Cidade();
            form.Show();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Bairro form = new Cadastro.Cadastro_Bairro();
            form.Show();
        }

        private void logradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Logradouro form = new Cadastro.Cadastro_Logradouro();
            form.Show();
        }

        private void tipoDeLogradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_TipoLogradouro form = new Cadastro.Cadastro_TipoLogradouro();
            form.Show();

        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Endereco form = new Cadastro.Cadastro_Endereco();
            form.Show();
        }

        private void cadastroParadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transporte.FrmParada form = new Transporte.FrmParada();
            form.Show();

        }

        private void cadastroPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transporte.FrmPonto form = new Transporte.FrmPonto();
            form.Show();
        }

        private void viagensProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transporte.Frm_Operacao form = new Transporte.Frm_Operacao();
            form.Show();
        }

        private void viaCEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FrmViaCep form = new Cadastro.FrmViaCep();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Cadastro.FrmViaCep form = new Cadastro.FrmViaCep();
            form.Show();

        }
    }
}
