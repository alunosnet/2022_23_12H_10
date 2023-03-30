
namespace ProjetoFinalMod15_.Paciente
{
    partial class f_verPacientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnInserirNovo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lbIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(357, 16);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(140, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btnInserirNovo
            // 
            this.btnInserirNovo.Location = new System.Drawing.Point(33, 387);
            this.btnInserirNovo.Name = "btnInserirNovo";
            this.btnInserirNovo.Size = new System.Drawing.Size(124, 40);
            this.btnInserirNovo.TabIndex = 3;
            this.btnInserirNovo.Text = "Inserir Novo";
            this.btnInserirNovo.UseVisualStyleBackColor = true;
            this.btnInserirNovo.Click += new System.EventHandler(this.btnInspecionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(451, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(664, 387);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(124, 40);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID Paciente";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(132, 59);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.ReadOnly = true;
            this.txtIDPaciente.Size = new System.Drawing.Size(25, 20);
            this.txtIDPaciente.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 20);
            this.txtNome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(107, 186);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(117, 20);
            this.dtpDataNasc.TabIndex = 15;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(53, 146);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(171, 20);
            this.txtCC.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Genero";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(56, 276);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(56, 326);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(168, 20);
            this.txtGenero.TabIndex = 23;
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(12, 234);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(34, 13);
            this.lbIdade.TabIndex = 24;
            this.lbIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(53, 234);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(171, 20);
            this.txtIdade.TabIndex = 25;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(238, 387);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(124, 40);
            this.btnAtualizar.TabIndex = 26;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // f_verPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnInserirNovo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "f_verPacientes";
            this.Text = "f_verPacientes";
            this.Load += new System.EventHandler(this.f_verPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnInserirNovo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnAtualizar;
    }
}