using M15_TrabalhoOficial_2022_23;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalMod15_.Paciente
{
    public class ConsultarPaciente
    {
        
        public int IDpaciente { get; set; }
        public string Nome { get; set; }
        public string CC { get; set; }
        public DateTime Data_nasc { get; set; }
        public string Idade { get; set; }
        public string Telefone { get; set; }
        public string Genero { get; set; }

        public ConsultarPaciente(int idpaciente, string nome, string cc, DateTime data_nasc, string idade, string telefone, string genero)
        {
            IDpaciente = idpaciente;
            Nome = nome;
            CC = cc;
            Data_nasc = data_nasc;
            Idade = idade;
            Telefone = telefone;
            Genero = genero;
        }

        public ConsultarPaciente()
        {

        }
        public void Atualizar(BaseDados bd)
        {
            string sql = @"UPDATE Paciente SET nome=@nome,cc=@cc,data_nasc=@data_nasc,idade=@idade,
                                telefone=@telefone,genero=@genero 
                                WHERE idpaciente=@idpaciente";

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
                    ParameterName="@data_nasc",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value=this.Data_nasc
                },
                new SqlParameter()
                {
                    ParameterName = "@cc",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.CC
                },
                new SqlParameter()
                {
                    ParameterName = "@telefone",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Telefone
                },
                new SqlParameter()
                {
                    ParameterName = "@genero",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Genero
                },
                new SqlParameter()
                {
                    ParameterName = "@idade",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Idade
                },
                new SqlParameter()
                {
                    ParameterName="@idpaciente",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.IDpaciente
                }

            };

            bd.ExecutaSQL(sql, parametros);

        }

        public void Guardar(BaseDados bd)
        {
            string sql = @"INSERT INTO Paciente(nome,cc,data_nasc,telefone,genero) VALUES 
                        (@nome,@cc,@data_nasc,@telefone,@genero)";
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
                    ParameterName="@data_nasc",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value=this.Data_nasc
                },
                new SqlParameter()
                {
                    ParameterName = "@cc",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.CC
                },
                new SqlParameter()
                {
                    ParameterName = "@telefone",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Telefone
                },
                new SqlParameter()
                {
                    ParameterName = "@genero",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.Genero
                },
                
            };
            
            bd.ExecutaSQL(sql, parametros);
        }

        public static DataTable ListarTodos(BaseDados bd)
        {
            string sql = "SELECT * FROM Paciente";
            return bd.DevolveSQL(sql);
        }

        public DataTable BuscarPessoa(string cc,BaseDados bd )
        {
            string sql = "SELECT * FROM Paciente WHERE CC like @CC";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {


                    ParameterName = "@CC",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value ="%" + cc + "%"

                }
            };
            DataTable dados = bd.DevolveSQL(sql,parametros);

            if (dados != null && dados.Rows.Count > 0)
            {

                this.IDpaciente = int.Parse(dados.Rows[0]["idpaciente"].ToString());
                this.Nome = dados.Rows[0]["nome"].ToString();
                this.CC = dados.Rows[0]["cc"].ToString();
                this.Data_nasc = DateTime.Parse(dados.Rows[0]["data_nasc"].ToString());
                this.Telefone = dados.Rows[0]["telefone"].ToString();
                this.Genero = dados.Rows[0]["genero"].ToString();
                this.Idade = dados.Rows[0]["idade"].ToString();

            }
            return dados;
        }
         



        public DataTable Procurar(int idpaciente, BaseDados bd)
        {
            string sql = "SELECT * FROM Paciente WHERE idpaciente=" + idpaciente;
            DataTable dados = bd.DevolveSQL(sql);

            if(dados != null && dados.Rows.Count > 0)
            {
            
                this.IDpaciente = int.Parse(dados.Rows[0]["idpaciente"].ToString());
                this.Nome = dados.Rows[0]["nome"].ToString();
                this.CC = dados.Rows[0]["cc"].ToString();
                this.Data_nasc = DateTime.Parse(dados.Rows[0]["data_nasc"].ToString());
                this.Telefone = dados.Rows[0]["telefone"].ToString();
                this.Genero = dados.Rows[0]["genero"].ToString();
                this.Idade = dados.Rows[0]["idade"].ToString();
                
            }
            return dados;
        }

        internal static void ApagarPaciente(BaseDados bd, int nPaciente)
        { 
            string sql = "DELETE FROM Paciente WHERE idpaciente=" + nPaciente;
            bd.ExecutaSQL(sql);
        }
    }
     
}
