namespace BusSpot.Transporte
{
    partial class FrmParada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParada));
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbCEP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.chkk_deletar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataLista.Location = new System.Drawing.Point(1, 208);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataLista.RowTemplate.Height = 25;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(416, 286);
            this.dataLista.TabIndex = 139;
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
            this.btnExcluir.Location = new System.Drawing.Point(420, 419);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 75);
            this.btnExcluir.TabIndex = 143;
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
            this.btnEditar.Location = new System.Drawing.Point(420, 338);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 75);
            this.btnEditar.TabIndex = 142;
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
            this.btnSalvar.Location = new System.Drawing.Point(420, 257);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 75);
            this.btnSalvar.TabIndex = 141;
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
            this.btnNovo.Location = new System.Drawing.Point(420, 188);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 75);
            this.btnNovo.TabIndex = 140;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbCEP
            // 
            this.cbCEP.Enabled = false;
            this.cbCEP.FormattingEnabled = true;
            this.cbCEP.Location = new System.Drawing.Point(272, 144);
            this.cbCEP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCEP.Name = "cbCEP";
            this.cbCEP.Size = new System.Drawing.Size(118, 23);
            this.cbCEP.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 149;
            this.label3.Text = "CEP:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(384, 12);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(118, 23);
            this.txt_Buscar.TabIndex = 151;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 150;
            this.label1.Text = "Buscar por Nome:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(7, 147);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(118, 23);
            this.txtLatitude.TabIndex = 152;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(133, 144);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(118, 23);
            this.txtLongitude.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 154;
            this.label2.Text = "Latitude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 155;
            this.label4.Text = "Longitude:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 72);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(488, 23);
            this.txtNome.TabIndex = 156;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 157;
            this.label5.Text = "Nome da Parada:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 159;
            this.label8.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(33, 15);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(37, 23);
            this.txt_ID.TabIndex = 158;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(73, 177);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(32, 15);
            this.lbl_total.TabIndex = 160;
            this.lbl_total.Text = "Total";
            // 
            // chkk_deletar
            // 
            this.chkk_deletar.AutoSize = true;
            this.chkk_deletar.Location = new System.Drawing.Point(7, 176);
            this.chkk_deletar.Name = "chkk_deletar";
            this.chkk_deletar.Size = new System.Drawing.Size(63, 19);
            this.chkk_deletar.TabIndex = 161;
            this.chkk_deletar.Text = "Deletar";
            this.chkk_deletar.UseVisualStyleBackColor = true;
            this.chkk_deletar.CheckedChanged += new System.EventHandler(this.chkk_deletar_CheckedChanged);
            // 
            // FrmParada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 506);
            this.Controls.Add(this.chkk_deletar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCEP);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmParada";
            this.Text = "Cadastro de Parada";
            this.Load += new System.EventHandler(this.FrmParada_Load);
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
        private ComboBox cbCEP;
        private Label label3;
        private TextBox txt_Buscar;
        private Label label1;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
        private Label label2;
        private Label label4;
        private TextBox txtNome;
        private Label label5;
        private Label label8;
        private TextBox txt_ID;
        private Label lbl_total;
        private CheckBox chkk_deletar;
    }
}