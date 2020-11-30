using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoxTruck
{
    class Cl_fornecedorDAO
    {
        string connstring = "Server=DESKTOP-ECQ57U5;Database=FOXTRUCK;User Id=admin;Password=admin;";
        
        
        public void create(Cl_fornecedor fornecedor)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            SqlCommand comm = connection.CreateCommand();
            //Executo comando de insert
            comm.CommandText = "INSERT INTO TbFornecedores (NomeFornecedor,CNPJ)" +
                "VALUES(@Nome,@CNPJ)";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Nome", fornecedor.NomeFornecedor);
            comm.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ1);
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
        public void delete(Cl_fornecedor fornecedor)
        {
            //Abro conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "DELETE FROM tbFornecedores where CNPJ=@CNPJ";
            comm.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ1);
            //Executo comando
            comm.ExecuteNonQuery(); //non query, pois não retorna row
            //Fecho Conexao
            connection.Close();
        }

        public void update(Cl_fornecedor fornecedor)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            //Executo comando de update
            comm.CommandText = "UPDATE tbFornecedores SET Fornecedor=@nome, CNPJ=@CNPJ,where CNPJ=@CNPJ";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Nome", fornecedor.NomeFornecedor);
            comm.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ1);
            //Executo o SQL
            comm.ExecuteNonQuery();  //non query, pois não retorna row
            //Fecha Conexao
            connection.Close();
        }       
    }
}
