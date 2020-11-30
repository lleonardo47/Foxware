using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoxTruck
{
    class Cl_clienteDAO
    {
        string connstring = "Server=DESKTOP-ECQ57U5;Database=FOXTRUCK;User Id=admin;Password=admin;";
        
        
        public void create(Cl_cliente cliente)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            SqlCommand comm = connection.CreateCommand();
            //Executo comando de insert
            comm.CommandText = "INSERT INTO TbClientes (NomeCliente,CPF,CNPJ,Cidade,Veiculo_ID) " +
                "VALUES(@Nome,@CPF, @CNPJ,@Cidade,@Veiculo)";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Nome", cliente.Nome_razao);
            comm.Parameters.AddWithValue("@CPF", cliente.Cpf_cnpj);
            comm.Parameters.AddWithValue("@CNPJ", cliente.Cpf_cnpj);
            comm.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            comm.Parameters.AddWithValue("@Veiculo", cliente.Idveiculo);
            //Executo o SQL
            comm.ExecuteNonQuery(); //non query, pois não retorna row

            connection.Close();
        }


        /*public List<Cl_cliente> readAll()
        {
            //Criando a lista para ser retornada
            List<Cl_cliente> clientes = new List<Cl_cliente>();
            //Abro conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            //Leio a tabela
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT * FROM tbClientes";
            //Guardo as rows no objeto reader
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())  //leio a proxima row, se tiver
            {
                
                clientes.Add();
            }
            //Fecho Conexao
            connection.Close();

            //Retorno a lista de estudantes
            return clientes;

        }*/
        public void delete(Cl_cliente cliente)
        {
            //Abro conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "DELETE FROM tbCliente where cpf=@cpf";
            comm.Parameters.AddWithValue("@cpf", cliente.Cpf_cnpj);
            //Executo comando
            comm.ExecuteNonQuery(); //non query, pois não retorna row
            //Fecho Conexao
            connection.Close();
        }

        public void update(Cl_cliente cliente)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            //Executo comando de update
            comm.CommandText = "UPDATE tbCliente SET nome=@nome, CPF=@CPF, CNPJ=@CNPJ,Cidade=@Cidade,Veiculo_ID=@Veiculo where CPF=@CPF";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Nome", cliente.Nome_razao);
            comm.Parameters.AddWithValue("@CPF", cliente.Cpf_cnpj);
            comm.Parameters.AddWithValue("@CNPJ", cliente.Cpf_cnpj);
            comm.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            comm.Parameters.AddWithValue("@Veiculo", cliente.Idveiculo);
            //Executo o SQL
            comm.ExecuteNonQuery();  //non query, pois não retorna row
            //Fecha Conexao
            connection.Close();
        }       
    }
}
