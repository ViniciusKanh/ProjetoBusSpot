namespace BusSpot.Transporte
{
    partial class FrmLinha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLinha));
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNumero_Linha = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.chkk_deletar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.cbPonto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLista.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataLista.Location = new System.Drawing.Point(12, 201);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataLista.RowTemplate.Height = 25;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(616, 193);
            this.dataLista.TabIndex = 114;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(400, 400);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 75);
            this.btnExcluir.TabIndex = 118;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(306, 400);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 75);
            this.btnEditar.TabIndex = 117;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(210, 400);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 75);
            this.btnSalvar.TabIndex = 116;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(115, 400);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 75);
            this.btnNovo.TabIndex = 115;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNumero_Linha
            // 
            this.txtNumero_Linha.Location = new System.Drawing.Point(123, 86);
            this.txtNumero_Linha.Mask = "0000/00";
            this.txtNumero_Linha.Name = "txtNumero_Linha";
            this.txtNumero_Linha.Size = new System.Drawing.Size(49, 23);
            this.txtNumero_Linha.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 137;
            this.label8.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(46, 42);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(37, 23);
            this.txt_ID.TabIndex = 136;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(86, 176);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(32, 15);
            this.lbl_total.TabIndex = 135;
            this.lbl_total.Text = "Total";
            // 
            // chkk_deletar
            // 
            this.chkk_deletar.AutoSize = true;
            this.chkk_deletar.Location = new System.Drawing.Point(17, 176);
            this.chkk_deletar.Name = "chkk_deletar";
            this.chkk_deletar.Size = new System.Drawing.Size(63, 19);
            this.chkk_deletar.TabIndex = 134;
            this.chkk_deletar.Text = "Deletar";
            this.chkk_deletar.UseVisualStyleBackColor = true;
            this.chkk_deletar.CheckedChanged += new System.EventHandler(this.chkk_deletar_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 132;
            this.label7.Text = "Empresa:";
            // 
            // txtDescrição
            // 
            this.txtDescrição.Enabled = false;
            this.txtDescrição.Location = new System.Drawing.Point(292, 86);
            this.txtDescrição.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(336, 23);
            this.txtDescrição.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 124;
            this.label3.Text = "Descrição da Linha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 123;
            this.label2.Text = "Numero da Linha:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(494, 34);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(134, 23);
            this.txt_Buscar.TabIndex = 122;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 119;
            this.label1.Text = "Buscar:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.Enabled = false;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(76, 134);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(118, 23);
            this.cbEmpresa.TabIndex = 139;
            // 
            // cbPonto
            // 
            this.cbPonto.Enabled = false;
            this.cbPonto.FormattingEnabled = true;
            this.cbPonto.Location = new System.Drawing.Point(292, 134);
            this.cbPonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPonto.Name = "cbPonto";
            this.cbPonto.Size = new System.Drawing.Size(118, 23);
            this.cbPonto.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 141;
            this.label4.Text = "Ponto:";
            // 
            // FrmLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 483);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPonto);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.txtNumero_Linha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.chkk_deletar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLinha";
            this.Text = "FrmLinha";
            this.Load += new System.EventHandler(this.FrmLinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataLista;
        private DataGridViewCheckBoxColumn Deletar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnNovo;
        private MaskedTextBox txtNumero_Linha;
        private Label label8;
        private TextBox txt_ID;
        private Label lbl_total;
        private CheckBox chkk_deletar;
        private Label label7;
        private TextBox txtDescrição;
        private Label label3;
        private Label label2;
        private TextBox txt_Buscar;
        private Label label1;
        private ComboBox cbEmpresa;
        private ComboBox cbPonto;
        private Label label4;
    }
}