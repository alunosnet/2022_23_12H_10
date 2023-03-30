
namespace ProjetoFinalMod15_.Mracacao
{
    partial class f_marcacaoexame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoConsulta = new System.Windows.Forms.TextBox();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.dtpDadosConsulta = new System.Windows.Forms.DataGridView();
            this.cmMedico = new System.Windows.Forms.ComboBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtEspecializacao = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDadosConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcar consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data/Hora";
            // 
            // txtTipoConsulta
            // 
            this.txtTipoConsulta.Location = new System.Drawing.Point(113, 109);
            this.txtTipoConsulta.Name = "txtTipoConsulta";
            this.txtTipoConsulta.Size = new System.Drawing.Size(165, 20);
            this.txtTipoConsulta.TabIndex = 7;
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.Location = new System.Drawing.Point(113, 66);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(165, 20);
            this.dtpDataHora.TabIndex = 8;
            // 
            // dtpDadosConsulta
            // 
            this.dtpDadosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpDadosConsulta.Location = new System.Drawing.Point(294, 12);
            this.dtpDadosConsulta.Name = "dtpDadosConsulta";
            this.dtpDadosConsulta.Size = new System.Drawing.Size(441, 335);
            this.dtpDadosConsulta.TabIndex = 9;
            this.dtpDadosConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpDadosConsulta_CellClick);
            // 
            // cmMedico
            // 
            this.cmMedico.FormattingEnabled = true;
            this.cmMedico.Location = new System.Drawing.Point(113, 179);
            this.cmMedico.Name = "cmMedico";
            this.cmMedico.Size = new System.Drawing.Size(165, 21);
            this.cmMedico.TabIndex = 10;
            this.cmMedico.SelectedIndexChanged += new System.EventHandler(this.cmMedico_SelectedIndexChanged);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(609, 367);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(126, 38);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(445, 367);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(126, 38);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome ";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(63, 285);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.ReadOnly = true;
            this.txtNomeMedico.Size = new System.Drawing.Size(215, 20);
            this.txtNomeMedico.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID Medico";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 262);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 16;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 320);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 13);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Especialização";
            // 
            // txtEspecializacao
            // 
            this.txtEspecializacao.Location = new System.Drawing.Point(101, 317);
            this.txtEspecializacao.Name = "txtEspecializacao";
            this.txtEspecializacao.ReadOnly = true;
            this.txtEspecializacao.Size = new System.Drawing.Size(177, 20);
            this.txtEspecializacao.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data/Hora";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(63, 388);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(104, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(231, 391);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(66, 20);
            this.txtGenero.TabIndex = 24;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(113, 206);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 25;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(113, 145);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(165, 20);
            this.dtpHora.TabIndex = 27;
            // 
            // f_marcacaoexame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 420);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEspecializacao);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.cmMedico);
            this.Controls.Add(this.dtpDadosConsulta);
            this.Controls.Add(this.dtpDataHora);
            this.Controls.Add(this.txtTipoConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f_marcacaoexame";
            this.Text = "f_marcacao";
            this.Load += new System.EventHandler(this.f_marcacaoexame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDadosConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoConsulta;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.DataGridView dtpDadosConsulta;
        private System.Windows.Forms.ComboBox cmMedico;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtEspecializacao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}