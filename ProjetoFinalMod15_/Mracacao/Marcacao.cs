using M15_TrabalhoOficial_2022_23;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalMod15_.Mracacao
{
    class Marcacao
    {
        
        public int IDMarcacao { get; set; }
        public int IDpaciente { get; set; }
        public int IDmedico { get; set; }
        public DateTime Data_Marcacao { get; set; }
        public DateTime Hora_Marcacao { get; set; }
        public string Tipo_Consulta { get; set; }

        public Marcacao(int idMarcacao, int iDpaciente, int iDmedico, DateTime data_Marcacao, DateTime hora_Marcacao, string tipo_Consulta)
        {
            IDMarcacao = idMarcacao;
            IDpaciente = iDpaciente;
            IDmedico = iDmedico;
            Data_Marcacao = data_Marcacao;
            Hora_Marcacao = hora_Marcacao;
            Tipo_Consulta = tipo_Consulta;
        }
        public Marcacao()
        {

        }
        public void GuardarConsulta(BaseDados bd)
        {
            string sql = @"INSERT INTO Marcacao(data_marcacao,hora_marcacao,tipoconsulta) VALUES 
                        (@data_marcacao,@hora_marcacao,@tipoconsulta)";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@tipoconsulta",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.Tipo_Consulta
                },
                new SqlParameter()
                {
                    ParameterName="@hora_marcacao",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.Hora_Marcacao.ToShortTimeString()
                },

                new SqlParameter()
                {
                    ParameterName="@data_marcacao",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value=this.Data_Marcacao
                },
                

            };
            bd.ExecutaSQL(sql, parametros);
        }

        internal DataTable Procurar(int idmarcacao, BaseDados bd)
        {
            string sql = "SELECT * FROM Marcacao WHERE Marcacao=" + idmarcacao;
            DataTable dados = bd.DevolveSQL(sql);

            if (dados != null && dados.Rows.Count > 0)
            {

               
                this.Tipo_Consulta = dados.Rows[0]["tipoconsulta"].ToString();
               
                this.Data_Marcacao = DateTime.Parse(dados.Rows[0]["data_marcacao"].ToString());
                this.Hora_Marcacao = DateTime.Parse(dados.Rows[0]["hora_marcacao"].ToString());

            }
            return dados;
        }

        public static DataTable ListarTodos(BaseDados bd)
        {
            string sql = "SELECT * FROM Marcacao";
            return bd.DevolveSQL(sql);
        }
    }


}
