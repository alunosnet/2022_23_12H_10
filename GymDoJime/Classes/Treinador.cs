using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GymDoJime.Classes
{
    public class Treinador
    {
        public int idutilizador;//admin pode atualizar
        public int idtreinador;//admin pode atualizar
        public string nome;//admin pode atualizar -- utilizador pode atualizar //
        public string email;//admin pode atualizar -- utilizador pode atualizar //
        public string password;//admin pode atualizar -- utilizador pode atualizar //
        public DateTime dataNasc;//admin pode atualizar 

        public DataTable devolveDadosUt(int idTreinador)
        {
            string sql = "SELECT * FROM Treinadores WHERE idtreinador = @idtreinador";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idtreinador", SqlDbType=SqlDbType.Int, Value=idTreinador}
            };
            return bd.devolveSQL(sql , parametros);
        }

        internal DataTable ListaTodosLivros()
        {
            string sql = "SELECT * FROM Treinadores";
            return bd.devolveSQL(sql);
        }


        internal DataTable ListaTodosUts()
        {
            string sql = "SELECT nomeTreinador FROM Treinadores";
            return bd.devolveSQL(sql);
        }

        public int idade;
        public string cc;//admin pode atualizar -- utilizador pode atualizar // 
        public string nif;//admin pode atualizar -- utilizador pode atualizar //
        public int sal;//admin pode atualizar 
        public string nacionalidade;//admin pode atualizar -- utilizador pode atualizar //
        public string telefone;//admin pode atualizar -- utilizador pode atualizar //
        public string genero;//admin pode atualizar //
        public string perfil;//admin pode atualizar // 



        BaseDados bd;

        public Treinador()
        {
            bd = new BaseDados();
        }
        public void Adicionar()
        {
            string sql = @"INSERT INTO Treinadores(nomeTreinador,emailTreinador,password,data_nasc,idade,ccTreinador,nifTreinador,nacionality,telefoneTreinador,genero,perfil,sal)
                            VALUES (@nomeTreinador,@emailTreinador,HASHBYTES('SHA2_512',concat(@password,@sal)),@data_nasc,@idade,@ccTreinador,@nifTreinador,@nacionality,@telefoneTreinador,@genero,@perfil,@sal)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@nomeTreinador",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.nome
                },
                new SqlParameter()
                {
                    ParameterName="@emailTreinador",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.email
                },
                new SqlParameter()
                {
                    ParameterName="@password",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.password
                },
                new SqlParameter()
                {
                    ParameterName="@data_nasc",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value=this.dataNasc
                },
                new SqlParameter()
                {
                    ParameterName="@idade",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.idade
                },
                 new SqlParameter()
                {
                    ParameterName="@ccTreinador",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.cc
                },
                 new SqlParameter()
                {
                    ParameterName="@nifTreinador",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.nif
                },
                new SqlParameter()
                {
                    ParameterName="@nacionality",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.nacionalidade
                },
                 new SqlParameter()
                {
                    ParameterName="@telefoneTreinador",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.telefone
                },
                new SqlParameter()
                {
                    ParameterName="@genero",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.genero
                },
                new SqlParameter()
                {
                    ParameterName="@perfil",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.perfil
                },
                new SqlParameter()
                {
                    ParameterName="@sal",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value = this.sal
                }



            };
            bd.executaSQL(sql, parametros);
        }

        public void RemoverTreinador(int idTreinador)
        {
            string sql = "DELETE FROM Treinadores WHERE idTreinador=@idTreinador";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idTreinador",SqlDbType=SqlDbType.Int,Value=idTreinador }
            };
            bd.executaSQL(sql, parametros);
        }

        public void atualizarTT()
        {
            string sql = "UPDATE Treinadores SET nomeTreinador = @nomeTreinador, emailTreinador=@emailTreinador,password=@password,data_nasc=@data_nasc,ccTreinador=@ccTreinador,nifTreinador=@nifTreinador,nacionality=@nacionality, telefoneTreinador=@telefoneTreinador, genero=@genero,perfil=@perfil,idade=@idade";
            sql += " WHERE  idtreinador=@idtreinador";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idtreinador", SqlDbType=SqlDbType.Int , Value = idtreinador},
                new SqlParameter() {ParameterName="@nomeTreinador", SqlDbType=SqlDbType.VarChar, Value= nome},
                new SqlParameter() {ParameterName="@emailTreinador", SqlDbType=SqlDbType.VarChar, Value= email},
                new SqlParameter() {ParameterName="@password", SqlDbType=SqlDbType.VarChar, Value= password},
                new SqlParameter() {ParameterName="@data_nasc", SqlDbType = SqlDbType.DateTime, Value=dataNasc},
                new SqlParameter() {ParameterName="@ccTreinador", SqlDbType=SqlDbType.VarChar, Value= cc},
                new SqlParameter() {ParameterName="@nifTreinador", SqlDbType=SqlDbType.VarChar, Value=nif},
                new SqlParameter() {ParameterName="@nacionality", SqlDbType = SqlDbType.VarChar, Value=nacionalidade},
                new SqlParameter() {ParameterName="@telefoneTreinador", SqlDbType=SqlDbType.VarChar, Value=telefone},
                new SqlParameter() {ParameterName="@genero", SqlDbType=SqlDbType.VarChar, Value=genero},
                new SqlParameter() {ParameterName="@perfil", SqlDbType= SqlDbType.VarChar, Value=perfil},
                new SqlParameter() {ParameterName="@idade", SqlDbType = SqlDbType.Int, Value=idade}
            };
            bd.executaSQL(sql, parametros);
        }
    }
}