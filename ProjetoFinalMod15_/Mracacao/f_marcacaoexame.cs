using M15_TrabalhoOficial_2022_23;
using ProjetoFinalMod15_.Medico;
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
    public partial class f_marcacaoexame : Form
    {
        BaseDados bd;
        public int IDpaciente;
        public int IDmedico;
        public f_marcacaoexame(BaseDados bd)
        {
            this.bd = bd;

            InitializeComponent();
            ComboBoxMedico();
            AtualizarGrelha();
        }

        public void ComboBoxMedico()
        {
            cmMedico.Items.Clear();
            DataTable dados = ConsultarMedico.ListarDisponiveis(bd);
            foreach (DataRow dr in dados.Rows)
            {
                ConsultarMedico medico = new ConsultarMedico();
                medico.IDmedico = int.Parse(dr["idmedico"].ToString());
                medico.Nome = dr["nome"].ToString();
                cmMedico.Items.Add(medico);
            }
        }
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void f_marcacaoexame_Load(object sender, EventArgs e)
        {

        }

        private void cmMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarMedico comp = cmMedico.SelectedItem as ConsultarMedico;
            if (comp == null)
            {
                MessageBox.Show("Precisa de escolher algum medico.");
            }
            else
            {
                txtID.Text = comp.IDmedico.ToString();
                txtNomeMedico.Text  = comp.Nome;
                txtEspecializacao.Text = comp.Especializacao;
                //dtpDataHora.Value = comp.Data_Nasc;
                txtTelefone.Text = comp.Telefone;
                txtGenero.Text = comp.Genero;

            }
        }

        private void dtpDadosConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dtpDadosConsulta.CurrentCell.RowIndex;
            if (linha == -1)
            {
                return;
            }
            int idmarcacao = int.Parse(dtpDadosConsulta.Rows[linha].Cells[0].Value.ToString());

            Marcacao marcacao = new Marcacao();

            marcacao.Procurar(idmarcacao, bd);

            
            
            txtTipoConsulta.Text = marcacao.Tipo_Consulta;
            dtpDataHora.Value = marcacao.Data_Marcacao;
            dtpHora.Value = marcacao.Hora_Marcacao;
           
           

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
           
            
            DateTime Data_nasc = dtpDataHora.Value;
            if (Data_nasc < DateTime.Now)
            {
                MessageBox.Show("A data de marcação deve ser maior ou igual a data atual");
                dtpDataHora.Focus();
                return;
            }

            DateTime Hora_Marcacao = dtpHora.Value;
            string tipoconsulta = txtTipoConsulta.Text;
            if(tipoconsulta == null)
            {
                MessageBox.Show("Deve preencher o tipo de consulta, para mossa imformção ");
                return;
            }
            
            //Criar um objeto Medico
            Marcacao guardarmarcacao = new Marcacao();
            //Preencher as propriedades

           

            guardarmarcacao.Data_Marcacao = dtpDataHora.Value;
            guardarmarcacao.Hora_Marcacao = dtpHora.Value;
            guardarmarcacao.Tipo_Consulta = txtTipoConsulta.Text;
            



            //Guardar na BD
            guardarmarcacao.GuardarConsulta(bd);
            //Limpar o form
            LimparForm();
            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            dtpDadosConsulta.AllowUserToAddRows = false;
            dtpDadosConsulta.AllowUserToDeleteRows = false;
            dtpDadosConsulta.ReadOnly = true;
            dtpDadosConsulta.DataSource = Marcacao.ListarTodos(bd);
        }

        private void LimparForm()
        {
            
            dtpDataHora.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtTipoConsulta.Text = "";
            cmMedico.Text = "";
        }
    }
}
