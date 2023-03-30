using M15_TrabalhoOficial_2022_23;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalMod15_.Paciente
{
    public partial class f_verPacientes : Form
    {
        BaseDados bd;
        int NPaciente;
        public f_verPacientes(BaseDados bd)
        {
            this.bd = bd;
            InitializeComponent();
            AtualizarGrelha();
            txtIdade.Visible = false;
            lbIdade.Visible = false;
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarGrelha()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ConsultarPaciente.ListarTodos(bd);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar os dados
            string nome = txtNome.Text;
            if (nome == ""  || nome.Length < 3)
            {
                MessageBox.Show("O nome deve conter pelo menos 3 letras");
                txtNome.Focus();
                return;
            }

            string cc = txtCC.Text;
            if (cc == "" || cc.Length < 8)
            {
                MessageBox.Show("O Cartão de cidadão deve conter os 8 numeros principais e os quatro caracteres finais ex:43526452 7 ZX6");
                txtCC.Focus();
                return;
            }
            DateTime Data_nasc = dtpDataNasc.Value;
            if (Data_nasc > DateTime.Now)
            {
                MessageBox.Show("A data de nascinento devev ser menor ou igual a data atual");
                dtpDataNasc.Focus();
                return;
            }
            string telefone = txtTelefone.Text;
            if (telefone.Length < 9|| telefone.Length > 9)
            {
                MessageBox.Show("O telefone nao deve conter letras, somente caracteres numericos e deve ter exatamente 9 NUMEROS");
                txtTelefone.Focus();
                return;
            }
            string genero = txtGenero.Text;
            if (!(genero == "M" || genero == "F"))
            {
                MessageBox.Show("O genero deve ser preenchido com M ou F");
                txtGenero.Focus();
                Console.WriteLine(genero);
                return;
            }
            string idade = txtIdade.Text;  
            
            


            //Criar um objeto Paciente
            ConsultarPaciente consultaPaciente = new ConsultarPaciente();
            //preencher as propriedades
            
            consultaPaciente.Nome = nome;
            consultaPaciente.CC = cc;
            consultaPaciente.Data_nasc = Data_nasc;
            consultaPaciente.Telefone = telefone;
            consultaPaciente.Genero = genero;
            consultaPaciente.Idade = idade;
            //Guardar na BD
            consultaPaciente.Guardar(bd);
            //Limpar o form
            LimparForm();
            AtualizarGrelha();
            lbIdade.Visible = false;
            txtIdade.Visible = false;


        }
        void LimparForm()
        {
            txtIDPaciente.Text = "";
            txtNome.Text = "";
            txtCC.Text = "";
            dtpDataNasc.Value = DateTime.Now;
            txtIdade.Text = "";
            txtTelefone.Text = "";
            txtGenero.Text = "";
        }

       
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void f_verPacientes_Load(object sender, EventArgs e)
        {

        }

        void ApagarPaciente()
        {
            
            if (NPaciente < 1)
            {
                MessageBox.Show("Tem de selecoinar um Paciente primeiro");
                return;
            }
            if (MessageBox.Show(
                "Tem a certeza que pretende eliminar o paciente selecionado?",
                "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConsultarPaciente.ApagarPaciente(bd, NPaciente);

                LimparForm();
                AtualizarGrelha();
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dataGridView1.CurrentCell.RowIndex;
            if (linha == -1)
            {
                return;
            }
            int idpaciente = int.Parse(dataGridView1.Rows[linha].Cells[0].Value.ToString());

            txtIdade.Visible = true;
            lbIdade.Visible = true;
            ConsultarPaciente pacinete = new ConsultarPaciente();

            pacinete.Procurar(idpaciente, bd);

            NPaciente = idpaciente;
            txtNome.Text = pacinete.Nome;
            txtCC.Text = pacinete.CC;
            dtpDataNasc.Value = pacinete.Data_nasc;
           
            txtTelefone.Text = pacinete.Telefone;
            txtGenero.Text = pacinete.Genero;
            txtIdade.Text = pacinete.Idade;
            txtIDPaciente.Text = pacinete.IDpaciente.ToString();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarPaciente();
            
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnInspecionar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Validar os dados
            string nome = txtNome.Text;
            if (nome == "" || nome.Length < 3)
            {
                MessageBox.Show("O nome deve conter pelo menos 3 letras");
                txtNome.Focus();
                return;
            }

            string cc = txtCC.Text;
            if (cc == "" || cc.Length < 8)
            {
                MessageBox.Show("O Cartão de cidadão deve conter os 8 numeros principais e os quatro caracteres finais ex:43526452 7 ZX6");
                txtCC.Focus();
                return;
            }
            DateTime Data_nasc = dtpDataNasc.Value;
            if (Data_nasc > DateTime.Now)
            {
                MessageBox.Show("A data de nascinento devev ser menor ou igual a data atual");
                dtpDataNasc.Focus();
                return;
            }
            string telefone = txtTelefone.Text;
            if (telefone.Length < 9 || telefone.Length > 9)
            {
                MessageBox.Show("O telefone nao deve conter letras, somente caracteres numericos e deve ter exatamente 9 NUMEROS");
                txtTelefone.Focus();
                return;
            }
            string genero = txtGenero.Text;
            if (!(genero == "M" || genero == "F"))
            {
                MessageBox.Show("O genero deve ser preenchido com M ou F");
                txtGenero.Focus();
                Console.WriteLine(genero);
                return;
            }
            string idade = txtIdade.Text;

            //Criar um objeto Paciente
            ConsultarPaciente atualizaPaciente = new ConsultarPaciente();
            //Preencher os dados
            atualizaPaciente.Nome = nome;
            atualizaPaciente.CC = cc;
            atualizaPaciente.Data_nasc = Data_nasc;
            atualizaPaciente.Idade = idade;
            atualizaPaciente.Telefone = telefone;
            atualizaPaciente.Genero = genero;
            atualizaPaciente.IDpaciente = NPaciente;
            //Guardar na bd
            atualizaPaciente.Atualizar(bd);
            //Limpar o forms
            LimparForm();
            AtualizarGrelha();
            


        }
    }
}
