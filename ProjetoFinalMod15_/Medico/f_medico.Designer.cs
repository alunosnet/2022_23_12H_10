
namespace ProjetoFinalMod15_.Medico
{
    partial class f_medico
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
            this.lblIDMedico = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtEspecializacao = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnInserirNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDMedico
            // 
            this.lblIDMedico.AutoSize = true;
            this.lblIDMedico.Location = new System.Drawing.Point(95, 59);
            this.lblIDMedico.Name = "lblIDMedico";
            this.lblIDMedico.Size = new System.Drawing.Size(18, 13);
            this.lblIDMedico.TabIndex = 0;
            this.lblIDMedico.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(3, 147);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(78, 13);
            this.lblEspecializacao.TabIndex = 4;
            this.lblEspecializacao.Text = "Especialização";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(3, 183);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(87, 13);
            this.lblDataNasc.TabIndex = 5;
            this.lblDataNasc.Text = "Data nascimento";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(26, 217);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Idade";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(19, 254);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(19, 286);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero";
            // 
            // txtEspecializacao
            // 
            this.txtEspecializacao.Location = new System.Drawing.Point(98, 140);
            this.txtEspecializacao.Name = "txtEspecializacao";
            this.txtEspecializacao.Size = new System.Drawing.Size(140, 20);
            this.txtEspecializacao.TabIndex = 9;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(74, 217);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(171, 20);
            this.txtIdade.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(74, 247);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(171, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(74, 283);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(171, 20);
            this.txtGenero.TabIndex = 13;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(96, 177);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(142, 20);
            this.dtpDataNasc.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 290);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(573, 327);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 46);
            this.btnApagar.TabIndex = 16;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(353, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 46);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnInserirNovo
            // 
            this.btnInserirNovo.Location = new System.Drawing.Point(74, 328);
            this.btnInserirNovo.Name = "btnInserirNovo";
            this.btnInserirNovo.Size = new System.Drawing.Size(118, 45);
            this.btnInserirNovo.TabIndex = 19;
            this.btnInserirNovo.Text = "Inserir Novo";
            this.btnInserirNovo.UseVisualStyleBackColor = true;
            this.btnInserirNovo.Click += new System.EventHandler(this.btnInserirNovo_Click);
            // 
            // f_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnInserirNovo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtEspecializacao);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblEspecializacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIDMedico);
            this.Name = "f_medico";
            this.Text = "f_medico";
            this.Load += new System.EventHandler(this.f_medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDMedico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtEspecializacao;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInserirNovo;
    }
}