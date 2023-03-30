
namespace ProjetoFinalMod15_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marcarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarExameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarTeleconsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarConsultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarConsultaToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // marcarConsultaToolStripMenuItem
            // 
            this.marcarConsultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarExameToolStripMenuItem,
            this.marcarTeleconsultaToolStripMenuItem,
            this.marcarConsultaToolStripMenuItem1});
            this.marcarConsultaToolStripMenuItem.Name = "marcarConsultaToolStripMenuItem";
            this.marcarConsultaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.marcarConsultaToolStripMenuItem.Text = "Marcar Consulta";
            // 
            // marcarExameToolStripMenuItem
            // 
            this.marcarExameToolStripMenuItem.Name = "marcarExameToolStripMenuItem";
            this.marcarExameToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.marcarExameToolStripMenuItem.Text = "Marcar exame";
            this.marcarExameToolStripMenuItem.Click += new System.EventHandler(this.marcarExameToolStripMenuItem_Click);
            // 
            // marcarTeleconsultaToolStripMenuItem
            // 
            this.marcarTeleconsultaToolStripMenuItem.Name = "marcarTeleconsultaToolStripMenuItem";
            this.marcarTeleconsultaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.marcarTeleconsultaToolStripMenuItem.Text = "Marcar Teleconsulta";
            this.marcarTeleconsultaToolStripMenuItem.Click += new System.EventHandler(this.marcarTeleconsultaToolStripMenuItem_Click);
            // 
            // marcarConsultaToolStripMenuItem1
            // 
            this.marcarConsultaToolStripMenuItem1.Name = "marcarConsultaToolStripMenuItem1";
            this.marcarConsultaToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.marcarConsultaToolStripMenuItem1.Text = "Marcar Consulta";
            this.marcarConsultaToolStripMenuItem1.Click += new System.EventHandler(this.marcarConsultaToolStripMenuItem1_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMédicosToolStripMenuItem});
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // verMédicosToolStripMenuItem
            // 
            this.verMédicosToolStripMenuItem.Name = "verMédicosToolStripMenuItem";
            this.verMédicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMédicosToolStripMenuItem.Text = "Ver médicos";
            this.verMédicosToolStripMenuItem.Click += new System.EventHandler(this.verMédicosToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPacientesToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // verPacientesToolStripMenuItem
            // 
            this.verPacientesToolStripMenuItem.Name = "verPacientesToolStripMenuItem";
            this.verPacientesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.verPacientesToolStripMenuItem.Text = "Ver Pacientes";
            this.verPacientesToolStripMenuItem.Click += new System.EventHandler(this.verPacientesToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar/Inserir Pacientes ";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem marcarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarExameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarTeleconsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarConsultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
    }
}

