using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoxTruck
{
    class Cl_veiculoDAO
    {
        string connstring = "Server=DESKTOP-ECQ57U5;Database=FOXTRUCK;User Id=admin;Password=admin;";
        
        
        public void create(Cl_veiculo veiculo)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            SqlCommand comm = connection.CreateCommand();
            //Executo comando de insert
            comm.CommandText = "INSERT INTO TbClientes (Tipo,Placa,Marca,Modelo,AnoModelo) " +
                "VALUES(@Tipo,@Placa, @Marca,@Modelo,@AnoModelo)";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Tipo", veiculo.Tipo);
            comm.Parameters.AddWithValue("@Placa", veiculo.Placa);
            comm.Parameters.AddWithValue("@Marca", veiculo.Marca);
            comm.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
            comm.Parameters.AddWithValue("@AnoModelo", veiculo.Anomodelo);
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
        public void delete(Cl_veiculo veiculo)
        {
            //Abro conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "DELETE FROM tbVeiculos where Placa=@Placa";
            comm.Parameters.AddWithValue("@Placa", veiculo.Placa);
            //Executo comando
            comm.ExecuteNonQuery(); //non query, pois não retorna row
            //Fecho Conexao
            connection.Close();
        }

        public void update(Cl_veiculo veiculo)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            //Executo comando de update
            comm.CommandText = "UPDATE tbCliente SET Tipo=@Tipo,Placa=@Placa,Marca=@Marca,Modelo=@Modelo,AnoModelo=@AnoModelo where Placa=@Placa";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Tipo", veiculo.Tipo);
            comm.Parameters.AddWithValue("@Placa", veiculo.Placa);
            comm.Parameters.AddWithValue("@Marca", veiculo.Marca);
            comm.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
            comm.Parameters.AddWithValue("@AnoModelo", veiculo.Anomodelo);
            //Executo o SQL
            comm.ExecuteNonQuery();  //non query, pois não retorna row
            //Fecha Conexao
            connection.Close();
        }       
    }
}
