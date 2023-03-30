using M15_TrabalhoOficial_2022_23;
using ProjetoFinalMod15_.Medico;
using ProjetoFinalMod15_.Mracacao;
using ProjetoFinalMod15_.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalMod15_
{
    public partial class Form1 : Form
    {
        BaseDados bd = new BaseDados("M15_TrabalhoOficial");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void marcarExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_marcarExame f_MarcarExame = new f_marcarExame(bd);
            f_MarcarExame.Show();
        }

        private void marcarTeleconsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcarConsultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void verMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_medico f_Medico = new f_medico(bd);
            f_Medico.Show();
        }

        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_verPacientes f_verPacientes = new f_verPacientes(bd);
            f_verPacientes.Show();
            
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_verPacientes f_verPacientes = new f_verPacientes(bd);
            f_verPacientes.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
