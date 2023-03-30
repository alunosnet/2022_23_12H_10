using M15_TrabalhoOficial_2022_23;
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

namespace ProjetoFinalMod15_.Mracacao
{
    public partial class f_marcarExame : Form
    {
        BaseDados bd;
        string CC;
        public f_marcarExame(BaseDados bd)
        {
            
            this.bd = bd;
            InitializeComponent();
            button1.Enabled = false;
            


        }

        private void f_marcarExame_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Validar o cc, se ele não for preenchido de forma correta da erro;
            string cc = txtCC.Text;
            if (cc == "")
            {
                MessageBox.Show("Deve preencher CC para confirmar os dados de seguida");
                return;
            }
            
            ConsultarPaciente paciente = new ConsultarPaciente();
            paciente.BuscarPessoa(cc,bd);


            //Preencher propriedades
            CC = cc;
            txtID.Text = paciente.IDpaciente.ToString();
            txtNome.Text = paciente.Nome;
            dtpDataNascimento.Value = paciente.Data_nasc;
            txtTelefone.Text = paciente.Telefone;
            txtGenero.Text = paciente.Genero;

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            f_marcacaoexame f_Marcacaoexame = new f_marcacaoexame(bd);
            f_Marcacaoexame.Show();
            


        }
    }
}
