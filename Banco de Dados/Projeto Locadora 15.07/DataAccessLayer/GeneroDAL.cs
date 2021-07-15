using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GeneroDAL : IGeneroService
    {
        public Response Insert(Genero g)
        {
            //Connection String 
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO GENEROS (NOME) VALUES (@NOME)";
            command.Parameters.AddWithValue("@NOME", g.Nome);
           
            Response resposta = new Response();
            try
            {
                //Try -> Analisa as linhas que podem vir a lançar exception
                connection.Open();
                command.ExecuteNonQuery();
                //Se chegou aqui, operação realizada com sucesso <3
                resposta.Success = true;
                resposta.Message = "Gênero cadastrado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                //Catch -> Captura erros encontrados no bloco try acima
                resposta.Success = false;

                //Se a UNIQUE KEY de gênero estourar, é pq este nome já foi cadastrado!
                if (ex.Message.Contains("UQ__GENEROS"))
                {
                    resposta.Message = "Gênero já cadastrado!";
                    return resposta;
                }

                //Se chegou aqui, é um erro no banco de dados que o usuário não pode fazer nada =(
                //É culpa do servidor do banco de dados ou da conexão do cliente/servidor
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                //Finally -> Garante que este código será executado.
                connection.Dispose();
            }

        }

        public DataResponse<Genero> GetAll()
        {
           
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM GENEROS ORDER BY ID";

            DataResponse<Genero> resposta = new DataResponse<Genero>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Genero> generos = new List<Genero>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Genero genero = new Genero();
                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Nome = Convert.ToString(reader["NOME"]);
                    generos.Add(genero);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = generos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Genero>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Genero g)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE GENEROS SET NOME = @NOME WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", g.Nome);
            command.Parameters.AddWithValue("@ID", g.ID);


            Response resposta = new Response();
            try
            {
                //Try -> Analisa as linhas que podem vir a lançar exception
                connection.Open();
                command.ExecuteNonQuery();
                //Se chegou aqui, operação realizada com sucesso <3
                resposta.Success = true;
                resposta.Message = "Gênero editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                //Catch -> Captura erros encontrados no bloco try acima
                resposta.Success = false;

                //Se a UNIQUE KEY de gênero estourar, é pq este nome já foi cadastrado!
                if (ex.Message.Contains("UQ__GENEROS"))
                {
                    resposta.Message = "Gênero já cadastrado!";
                    return resposta;
                }

                //Se chegou aqui, é um erro no banco de dados que o usuário não pode fazer nada =(
                //É culpa do servidor do banco de dados ou da conexão do cliente/servidor
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                //Finally -> Garante que este código será executado.
                connection.Dispose();
            }

        }

        public Response Delete(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM GENEROS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();
            try
            {
                //Try -> Analisa as linhas que podem vir a lançar exception
                connection.Open();
                command.ExecuteNonQuery();
                //Se chegou aqui, operação realizada com sucesso <3
                resposta.Success = true;
                resposta.Message = "Gênero excluído com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                //Catch -> Captura erros encontrados no bloco try acima
                resposta.Success = false;
                //Se a UNIQUE KEY de gênero estourar, é pq este nome já foi cadastrado!
                if (ex.Message.Contains("FK__FILMES__GENERO"))
                {
                    resposta.Message = "Gênero não pode ser excluído, pois existem filmes vinculados a ele!";
                    return resposta;
                }

                //Se chegou aqui, é um erro no banco de dados que o usuário não pode fazer nada =(
                //É culpa do servidor do banco de dados ou da conexão do cliente/servidor
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                //Finally -> Garante que este código será executado.
                connection.Dispose();
            }

        }
    }
}
