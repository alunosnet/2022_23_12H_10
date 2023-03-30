using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GymDoJime.Classes
{
    public class Utilizadores
    {
        public int idutilizador;//admin pode atualizar
        public int idtreinador;//admin pode atualizar
        public string nome;//admin pode atualizar -- utilizador pode atualizar //
        public string email;//admin pode atualizar -- utilizador pode atualizar //
        public string password;//admin pode atualizar -- utilizador pode atualizar //
        public DateTime dataNasc;//admin pode atualizar 
        public string cc;//admin pode atualizar -- utilizador pode atualizar // 
        public string nif;//admin pode atualizar -- utilizador pode atualizar //
        public int sal;//admin pode atualizar 
        public int nacionalidade;//admin pode atualizar -- utilizador pode atualizar //
        public string telefone;//admin pode atualizar -- utilizador pode atualizar //
        public int genero;//admin pode atualizar //
        public int perfil;//admin pode atualizar // 
        public int idade;

        internal DataTable ListaTodosLivros()
        {
            string sql = "SELECT * FROM Utilizadores";
            return bd.devolveSQL(sql);
        }

        internal DataTable ListaTodosUts()
        {
            return bd.devolveSQL("SELECT idutilizador, nome FROM Utilizadores");
        }


       
        internal DataTable devolveDadosUt(int idUtilizador)
        {
            string sql = "SELECT * FROM Utilizadores WHERE idutilizador = @idutilizador";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idutilizador", SqlDbType=SqlDbType.Int, Value=idUtilizador}
            };
            return bd.devolveSQL(sql, parametros);
        }
        internal DataTable devolveDadosUts()
        {
            string sql = "SELECT idutilizador, Nome, email, telefone, genero, idade FROM Utilizadores WHERE perfil = 1";
      
            return bd.devolveSQL(sql);
        }





        BaseDados bd;

        internal void RemoverTreinador(int idUtilizador)
        {
            string sql = "DELETE FROM Utilizadores WHERE idutilizador=@idutilizador";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idutilizador",SqlDbType=SqlDbType.Int,Value=idUtilizador }
            };
            bd.executaSQL(sql, parametros);
        }

        public Utilizadores()
        {
            bd = new BaseDados();
        }

        public void Adicionar()
        {
            string sql = @"INSERT INTO Utilizadores(nome,email,password,data_nascimento,idade,cc,nif,nacionalidade,telefone,genero,perfil,sal)
                            VALUES (@nome,@email,HASHBYTES('SHA2_512',concat(@password,@sal)),@data_nascimento,@idade,@cc,@nif,@nacionalidade,@telefone,@genero,@perfil,@sal)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@nome",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.nome
                },
                new SqlParameter()
                {
                    ParameterName="@email",
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
                    ParameterName="@data_nascimento",
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
                    ParameterName="@cc",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.cc
                },
                 new SqlParameter()
                {
                    ParameterName="@nif",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.nif
                },
                new SqlParameter()
                {
                    ParameterName="@nacionalidade",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value=this.nacionalidade
                },
                 new SqlParameter()
                {
                    ParameterName="@telefone",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.telefone
                },
                new SqlParameter()
                {
                    ParameterName="@genero",
                    SqlDbType=System.Data.SqlDbType.VarChar,
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

        internal void atualizarUT()
        {
            string sql = "UPDATE Utilizadores SET nome = @nome, email=@email,password=@password,data_nascimento=@data_nascimento,cc=@cc,nif=@nif,nacionalidade=@nacionalidade, telefone=@telefone, genero=@genero,perfil=@perfil,idade=@idade";
            sql += " WHERE  idutilizador=@idutilizador";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idutilizador", SqlDbType=SqlDbType.Int , Value = idutilizador},
                new SqlParameter() {ParameterName="@nome", SqlDbType=SqlDbType.VarChar, Value= nome},
                new SqlParameter() {ParameterName="@email", SqlDbType=SqlDbType.VarChar, Value= email},
                new SqlParameter() {ParameterName="@password", SqlDbType=SqlDbType.VarChar, Value= password},
                new SqlParameter() {ParameterName="@data_nascimento", SqlDbType = SqlDbType.DateTime, Value=dataNasc},
                new SqlParameter() {ParameterName="@cc", SqlDbType=SqlDbType.VarChar, Value= cc},
                new SqlParameter() {ParameterName="@nif", SqlDbType=SqlDbType.VarChar, Value=nif},
                new SqlParameter() {ParameterName="@nacionalidade", SqlDbType = SqlDbType.VarChar, Value=nacionalidade},
                new SqlParameter() {ParameterName="@telefone", SqlDbType=SqlDbType.VarChar, Value=telefone},
                new SqlParameter() {ParameterName="@genero", SqlDbType=SqlDbType.VarChar, Value=genero},
                new SqlParameter() {ParameterName="@perfil", SqlDbType= SqlDbType.VarChar, Value=perfil},
                new SqlParameter() {ParameterName="@idade", SqlDbType = SqlDbType.Int, Value=idade}
            };
            bd.executaSQL(sql, parametros);
        }

        internal DataTable ListaTodosUtilizadores()
        {
            return bd.devolveSQL("SELECT * FROM Utilizadores");
        }

        public DataTable listaTodosUtilizadoresDisponiveis()
        {
            string sql = $@"SELECT id, email,nome, morada, nif,  estado, perfil 
            FROM utilizadores where perfil=1";
            return bd.devolveSQL(sql);
        }

        public void removerUtilizador(int idutilizador)
        {
            string sql = "DELETE FROM Utilizadores WHERE idutilizador=@idutilizador";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idutilizador",SqlDbType=SqlDbType.Int,Value= idutilizador},
            };
            bd.executaSQL(sql, parametros);
        }
        public void atualizarUtilizador()
        {
            string sql = @"UPDATE utilizadores SET nome = @nome, email = @email, password = @password,data_nascimento=@data_nascimento, cc = @cc,nif_@nif, nacionalidade = @nacionalidade, telefone = @telefone , genero=@genero,perfil=@perfil,idade=@idade 
                            WHERE idutilizador=@idutilizador";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@idutilizador", SqlDbType = SqlDbType.Int , Value=idutilizador},
                new SqlParameter() {ParameterName="@nome",SqlDbType=SqlDbType.VarChar,Value=nome },
                new SqlParameter() {ParameterName="@email",SqlDbType=SqlDbType.VarChar,Value=email  },
                new SqlParameter() {ParameterName="@password",SqlDbType=SqlDbType.VarChar,Value=password },
                new SqlParameter() {ParameterName="@data_nascimento", SqlDbType = SqlDbType.DateTime , Value=dataNasc},
                new SqlParameter() {ParameterName="@cc",SqlDbType=SqlDbType.VarChar,Value=cc },
                new SqlParameter() {ParameterName="@nif", SqlDbType=SqlDbType.VarChar, Value=nif},
                new SqlParameter() {ParameterName="@nacionalidade",SqlDbType=SqlDbType.VarChar,Value=nacionalidade },
                new SqlParameter() {ParameterName="@telefone",SqlDbType=SqlDbType.VarChar,Value=telefone},
                new SqlParameter() {ParameterName="@genero", SqlDbType=SqlDbType.Int, Value=genero},
                new SqlParameter() {ParameterName="@perfil",SqlDbType=SqlDbType.Int, Value=perfil},
                new SqlParameter() {ParameterName="@idade", SqlDbType=SqlDbType.Int, Value=idade}
                

            };
            bd.executaSQL(sql, parametros);
        }


        



    }
}