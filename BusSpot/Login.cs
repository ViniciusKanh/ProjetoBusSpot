namespace BusSpot
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width/2-166,this.Height/2-170);
            btn_Entrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(21,114,160);
            btn_Entrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
        }
    }
}