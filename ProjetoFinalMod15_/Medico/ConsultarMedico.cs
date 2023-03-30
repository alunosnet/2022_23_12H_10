using M15_TrabalhoOficial_2022_23;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalMod15_.Medico
{
    public class ConsultarMedico
    {
        
        public int IDmedico { get; set; }
        public string Nome { get; set; }
        public string Especializacao { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Idade { get; set; }
        public string Telefone { get; set; }
        public string Genero { get; set; }


        public ConsultarMedico(int idmedico, string nome, string especializacao, DateTime data_nasc, string idade, string telefone, string genero)
        {
            IDmedico = idmedico;
            Nome = nome;
            Especializacao = especializacao;
            Data_Nasc = data_nasc;
            Idade = idade;
            Telefone = telefone;
            Genero = genero;
        }
        public ConsultarMedico()
        {

        }
        public static DataTable ListarDisponiveis(BaseDados bd)
        {
            string sql = "SELECT * FROM Medico";
            return bd.DevolveSQL(sql);
        }

        internal static void ApagarMedico(BaseDados bd, int NMedico)
        {
            string sql = "DELETE FROM Medico WHERE idmedico=" + NMedico;
            bd.ExecutaSQL(sql);
        }
        public void Guardar(BaseDados bd)
        {
            string sql = @"INSERT INTO Medico(nome,especializacao,data_nascimento,telefone,genero) VALUES 
                        (@nome,@especializacao,@data_nascimento,@telefone,@genero)";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@nome",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.Nome
                },
                new SqlParameter()
                {
                    ParameterName = "@especializacao",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value=this.Especializacao
                },
                new SqlParameter()
                {
                    ParameterName="@data_nascimento",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value=this.Data_Nasc
                },
                new SqlParameter()
                {
                    ParameterName = "@genero",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Genero
                },
                new SqlParameter()
                {
                    ParameterName = "@telefone",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Telefone
                },

            };
            bd.ExecutaSQL(sql, parametros);


        }

        internal static void ApagarPaciente(BaseDados bd, int nMedico)
        {
            
            string sql = "DELETE FROM Medico WHERE idmedico=" + nMedico;
            bd.ExecutaSQL(sql);
            
        }

        public static DataTable ListarTodos(BaseDados bd)
        {
            string sql = "SELECT * FROM Medico";
            return bd.DevolveSQL(sql);
        }

        internal DataTable Procurar(int idmedico, BaseDados bd)
        {
            string sql = "SELECT * FROM Medico WHERE idmedico=" + idmedico;
            DataTable dados = bd.DevolveSQL(sql);

            if (dados != null && dados.Rows.Count > 0)
            {

                this.IDmedico = int.Parse(dados.Rows[0]["idmedico"].ToString());
                this.Nome = dados.Rows[0]["nome"].ToString();
                this.Especializacao = dados.Rows[0]["especializacao"].ToString();
                this.Data_Nasc = DateTime.Parse(dados.Rows[0]["data_nascimento"].ToString());
                this.Telefone = dados.Rows[0]["telefone"].ToString();
                this.Genero = dados.Rows[0]["genero"].ToString();
                this.Idade = dados.Rows[0]["idade"].ToString();

            }
            return dados;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }



   



}
