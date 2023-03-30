
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace GymDoJime.Classes
{
    internal class Presenças
    {
        BaseDados bd;
        public bool presenças;
        public int idutilizador;
        public int idmarcacao;



        public Presenças()
        {
            bd = new BaseDados();
        }


        internal void InserirPresença()
        {
            string sql = @"INSERT INTO Presenças(idmarcacao, idutilizador, presença ) values(@idmarcacao, @idutilizador, @presença)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@idmarcacao",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.idmarcacao
                },
                new SqlParameter()
                {
                    ParameterName="@idutilizador",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.idutilizador
                },
                new SqlParameter()
                {
                    ParameterName = "@presença",
                    SqlDbType = System.Data.SqlDbType.Bit,
                    Value = this.presenças

                },

            };
            bd.executaSQL(sql, parametros);
        }
    }
}