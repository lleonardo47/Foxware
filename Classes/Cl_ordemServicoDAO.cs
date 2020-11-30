using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoxTruck
{
    class Cl_ordemServicoDAO
    {
        string connstring = "Server=DESKTOP-ECQ57U5;Database=FOXTRUCK;User Id=admin;Password=admin;";
        
        
        public void create(Cl_ordemServico ordemServico)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            SqlCommand comm = connection.CreateCommand();
            //Executo comando de insert
            comm.CommandText = "INSERT INTO TbOrdemServico (IdFunc_OS,IdCliente_OS,IdServico_OS,Quantidade,DataEntrada,DataSaida,ValorTotal) " +
                "VALUES(@IdFunc,@IdCliente, @IdServico,@Quantidade,@DataEntrada,@DataSaida,,@ValorTotal)";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@IdFunc", ordemServico.IdFunc);
            comm.Parameters.AddWithValue("@IdCliente", ordemServico.IdCliente);
            comm.Parameters.AddWithValue("@IdServico", ordemServico.IdServico);
            comm.Parameters.AddWithValue("@Quantidade", ordemServico.Quantidade);
            comm.Parameters.AddWithValue("@DataEntrada", ordemServico.DataEntrada);
            comm.Parameters.AddWithValue("@DataSaida", ordemServico.DataSaida);
            comm.Parameters.AddWithValue("@ValorTotal", ordemServico.ValorTotal);
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
        public void delete(Cl_ordemServico ordemServico)
        {
            //Abro conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "DELETE FROM tbOrdemServico where IdOrdemServico=@OS";
            comm.Parameters.AddWithValue("@OS", ordemServico.NumOS);
            //Executo comando
            comm.ExecuteNonQuery(); //non query, pois não retorna row
            //Fecho Conexao
            connection.Close();
        }

            
    }
}
