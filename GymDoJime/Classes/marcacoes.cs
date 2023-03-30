using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace GymDoJime.Classes
{
    public class marcacoes

    {
        BaseDados bd;
        public DateTime dataHora;
        public string sala;
        public string TipoTreino;
        public string tipoAula;
        public int idmarcacao;
        public int idtreinador;

        public marcacoes()
        {
            bd = new BaseDados();
        }

        public DataTable ListaTodasMarcacoes()
        {
            string sql = "SELECT * FROM Marcacao ";
            return bd.devolveSQL(sql);
        }

        public DataTable ListaTodasMarcacao()
        {
            string sql = "SELECT idmarcacao,data_hora FROM Marcacao ";
            return bd.devolveSQL(sql);
        }

        public void atualizarTT()
        {
            string sql = "UPDATE Marcacao SET data_hora=@data_hora,sala = @sala, tipo_de_treino = @tipo_de_treino, tipo_de_aula = @tipo_de_aula, idtreinador = @idtreinador";
            sql += " WHERE  idmarcacao=@idmarcacao";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idmarcacao", SqlDbType=SqlDbType.Int , Value = idtreinador},
                new SqlParameter() {ParameterName="@sala", SqlDbType = SqlDbType.VarChar, Value = sala},
                new SqlParameter() {ParameterName="@data_hora", SqlDbType=SqlDbType.VarChar, Value=dataHora},
                new SqlParameter() {ParameterName="@tipo_de_treino", SqlDbType=SqlDbType.VarChar, Value= TipoTreino},
                new SqlParameter() {ParameterName="@tipo_de_aula", SqlDbType=SqlDbType.VarChar, Value= tipoAula},
                new SqlParameter() {ParameterName="@idtreinador", SqlDbType=SqlDbType.Int, Value= idtreinador},


            };
            bd.executaSQL(sql, parametros);
        }


        public DataTable ListaTodasMarcacoes(int idmarcacao)
        {
            string sql = "SELECT * FROM Marcacao WHERE idmarcacao = " + idmarcacao;
            
            return bd.devolveSQL(sql);
        }

        public void DeleteAulas(int idmarcacao)
        {
            string sql = "DELETE FROM Marcacao WHERE idmarcacao=@idmarcacao";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idmarcacao",SqlDbType=SqlDbType.Int,Value=idmarcacao }
            };
            bd.executaSQL(sql, parametros);

        }

        internal void InserirConsulta()
        {
            string sql = @"INSERT INTO Marcacao(data_hora, sala, tipo_de_treino, tipo_de_aula, idtreinador ) values(@data_hora, @sala, @tipo_de_treino, @tipo_de_aula, @idtreinador)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@data_hora",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value=this.dataHora
                },
                new SqlParameter()
                {
                    ParameterName="@sala",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.sala
                },
                new SqlParameter()
                {
                    ParameterName = "@tipo_de_treino",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.TipoTreino

                },
                new SqlParameter()
                {
                    ParameterName = "@tipo_de_aula",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.tipoAula

                },
          
                new SqlParameter()
                {
                    ParameterName = "@idtreinador",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.idtreinador

                }
            };
            bd.executaSQL(sql, parametros);
        }
    }
}