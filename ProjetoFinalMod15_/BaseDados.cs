using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//
// Copyright (c) 2022 Paulo Ferreira. All rights reserved.
//

namespace M15_TrabalhoOficial_2022_23
{
    public class BaseDados
    {
        string ligaBD;
        SqlConnection sqlConnection;
        string NomeBD;
        string caminhoBD;
        /*construtor*/
        public BaseDados(string NomeBD)
        {
            ligaBD = ConfigurationManager.ConnectionStrings["servidor"].ToString();
            this.NomeBD = NomeBD;
            string caminhoBD = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            caminhoBD += "\\M15_TrabalhoOficial\\";
            this.caminhoBD = caminhoBD + NomeBD + ".mdf";
            if (System.IO.Directory.Exists(caminhoBD) == false)
            {
                System.IO.Directory.CreateDirectory(caminhoBD);
            }
            if (System.IO.File.Exists(this.caminhoBD) == false)
            {
                CriarBD();
            }
            //ligação BD
            sqlConnection = new SqlConnection(ligaBD);
            sqlConnection.Open();
            sqlConnection.ChangeDatabase(NomeBD);

        }
        /*destrutor*/
        ~BaseDados()
        {
            try
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch
            {
                //Pode ocorrer erros 
            }
        }
        private void CriarBD()
        {
            //ligar ao servidor BD
            sqlConnection = new SqlConnection(ligaBD);
            sqlConnection.Open();
            //criar a BD
            string sql = $"CREATE DATABASE {NomeBD} ON PRIMARY (NAME={NomeBD},FILENAME='{caminhoBD}')";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.ChangeDatabase(NomeBD);
            //criar as tabelas
            sql = @"Create table Paciente(
	                    idpaciente int identity primary key ,
	                    nome varchar(50) check(len(nome) >= 3),
	                    CC varchar(13) NOT NULL,
	                    data_nasc date NOT NULL,
	                    idade int,
	                    telefone varchar(9),
	                    genero varchar(1) check(genero = 'M' or genero = 'F') NOT NULL
                    );

                    Create table Medico(
	                    idmedico int identity primary key ,
	                    nome varchar(50) check(len(nome) >= 3),
	                    especializacao varchar(50) check(len(especializacao) >= 3),
	                    data_nascimento date,
	                    idade int,
	                    telefone varchar(9) NOT NULL,
	                    genero varchar(1) check(genero='M' or genero='F') NOT NULL
                    );

                    Create table Marcacao(
	                    Marcacao int identity primary key,
	                    idpaciente int references Paciente(idpaciente),
	                    idmedico int references Medico(idmedico),
	                    data_marcacao date default(getdate()),
	                    hora_marcacao varchar(10),
	                    tipoconsulta varchar(50)
                    );";

            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sql = @" Create Trigger CalcularIdadePaciente 
                        ON Paciente
                        AFTER INSERT AS 
                        BEGIN

	                        Declare @data_nasc date;
	                        Declare @idade int;
	                        Declare @idpaciente int;
	                        select @idpaciente = INSERTED.idpaciente FROM INSERTED;
	                        SELECT @data_nasc = INSERTED.data_nasc from INSERTED;
	                        set @idade = datediff(year,@data_nasc, getdate()); 
	                        UPDATe Paciente
	                        set idade=@idade
	                        where Paciente.idpaciente = @idpaciente
                        END	";

            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sql = @"Create Trigger CalcularIdadeMedico 
                        ON Medico
                        AFTER INSERT AS 
                        BEGIN

	                        Declare @data_nascimento date;
	                        Declare @idade int;
	                        Declare @idmedico int;
	                        select @idmedico = INSERTED.idmedico FROM INSERTED;
	                        SELECT @data_nascimento = INSERTED.data_nascimento from INSERTED;
	                        set @idade = datediff(year,@data_nascimento, getdate()); 
	                        UPDATe Medico
	                        set idade=@idade
	                        where Medico.idmedico = @idmedico
                        END";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sql = @" Create Trigger AtulizarIdadePaciente 
                        ON Paciente
                        AFTER update AS 
                        BEGIN

	                        Declare @data_nasc date;
	                        Declare @idade int;
	                        Declare @idpaciente int;
	                        select @idpaciente = INSERTED.idpaciente FROM INSERTED;
	                        SELECT @data_nasc = INSERTED.data_nasc from INSERTED;
	                        set @idade = datediff(year,@data_nasc, getdate()); 
	                        UPDATe Paciente
	                        set idade=@idade
	                        where Paciente.idpaciente = @idpaciente
                        END	";

            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            //fechar a ligação ao servidor BD
            sqlCommand.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        /// <summary>
        /// Vai executar um SQL que altera os dados (p.e:insert, delete ou update)
        /// </summary>
        public void ExecutaSQL(string sql, List<SqlParameter> parametros = null)
        {
            //TODO: Adicionar transações
            SqlCommand comando = new SqlCommand(sql, sqlConnection);
            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            comando.ExecuteNonQuery();
            comando.Dispose();
            comando = null;
        }
        /// <summary>
        /// Executa uma consulta e devolve os dados da bd
        /// </summary>
        /// <returns>Um datatable com o resultado da consulta</returns>
        public DataTable DevolveSQL(string sql, List<SqlParameter> parametros = null)
        {
            //TODO: adicionar transações
            SqlCommand comando = new SqlCommand(sql, sqlConnection);
            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            DataTable dados = new DataTable();

            SqlDataReader registos = comando.ExecuteReader();
            dados.Load(registos);

            registos.Close();
            comando.Dispose();
            registos = null;
            comando = null;

            return dados;
        }

    }
}