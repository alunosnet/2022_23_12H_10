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

namespace ProjetoFinalMod15_.Medico
{
    public partial class f_medico : Form
    {
        BaseDados bd;
        int NMedico;
        public f_medico(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            txtIdade.Visible = false;
            lblIdade.Visible = false;
            AtualizarGrelha();
        }

        void LimparForm()
        {
            textBox1.Text = "";
            txtNome.Text = "";
            txtEspecializacao.Text = "";
            dtpDataNasc.Value = DateTime.Now;
            txtIdade.Text = "";
            txtTelefone.Text = "";
            txtGenero.Text = "";
        }
        private void AtualizarGrelha()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ConsultarMedico.ListarTodos(bd);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar os dados
            string nome = txtNome.Text;
            if (nome == "" || nome.Length < 3)
            {
                MessageBox.Show("O nome deve conter pelo menos 3 letras");
                txtNome.Focus();
                return;
            }
            string especializacao = txtEspecializacao.Text;
            if (especializacao == "" || especializacao.Length < 3)
            {
                MessageBox.Show("A especializacao deve conter pelo mais do que 3 letras");
                txtEspecializacao.Focus();
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
            
            //Criar um objeto Paciente
            ConsultarMedico guardarmedico = new ConsultarMedico();
            //Preencher as propriedades
            guardarmedico.Nome = txtNome.Text;
            guardarmedico.Especializacao = txtEspecializacao.Text;
            guardarmedico.Data_Nasc = dtpDataNasc.Value;
            guardarmedico.Telefone = txtTelefone.Text;
            guardarmedico.Genero = txtGenero.Text;
           


            //Guardar na BD
            guardarmedico.Guardar(bd);
            //Limpar o form
            LimparForm();
            AtualizarGrelha();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarMedico();
        }

        

        void ApagarMedico()
        {

            if (NMedico < 1)
            {
                MessageBox.Show("Tem de selecoinar um Medico primeiro");
                return;
            }
            if (MessageBox.Show(
                "Tem a certeza que pretende eliminar o medico selecionado?",
                "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConsultarMedico.ApagarMedico(bd, NMedico);

                LimparForm();
                AtualizarGrelha();
            }
        }

        private void btnInserirNovo_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dataGridView1.CurrentCell.RowIndex;
            if (linha == -1)
            {
                return;
            }
            int idmedico = int.Parse(dataGridView1.Rows[linha].Cells[0].Value.ToString());

            txtIdade.Visible = true;
            lblIdade.Visible = true;
            ConsultarMedico pacinete = new ConsultarMedico();

            pacinete.Procurar(idmedico, bd);

            textBox1.Text = idmedico.ToString();
            txtNome.Text = pacinete.Nome;
            txtEspecializacao.Text = pacinete.Especializacao;
            dtpDataNasc.Value = pacinete.Data_Nasc;
            txtTelefone.Text = pacinete.Telefone;
            txtGenero.Text = pacinete.Genero;
            txtIdade.Text = pacinete.Idade;
            

        }

        private void f_medico_Load(object sender, EventArgs e)
        {

        }
    }
}

