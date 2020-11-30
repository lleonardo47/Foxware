using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoxTruck
{
    class Cl_funcionarioDAO
    {
        string connstring = "Server=DESKTOP-ECQ57U5;Database=FOXTRUCK;User Id=admin;Password=admin;";
        
        public void create(Cl_funcionario funcionario)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            SqlCommand comm = connection.CreateCommand();
            //Executo comando de insert
            comm.CommandText = "INSERT INTO TbFuncionarios (NomeFunc,CPF,RG,DataNascimento,Endereco,Cidade,Cargo,Salario,Dependentes,QtdDependentes,DataAdmissao) " +
                "VALUES(@Nome,@CPF,@RG,@DataNasc,@Endereco,@Cidade,@Cargo,@Salario,@Dependentes,@QtdDependentes,@DataAdmissao)";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Nome", funcionario.Nome);
            comm.Parameters.AddWithValue("@CPF", funcionario.Nome);
            comm.Parameters.AddWithValue("@RG", funcionario.Nome);
            comm.Parameters.AddWithValue("@DataNasc", funcionario.Nome);
            comm.Parameters.AddWithValue("@Endereco", funcionario.Nome);
            comm.Parameters.AddWithValue("@Cidade", funcionario.Nome);
            comm.Parameters.AddWithValue("@Cargo", funcionario.Nome);
            comm.Parameters.AddWithValue("@Salario", funcionario.Nome);
            comm.Parameters.AddWithValue("@Dependentes", funcionario.Nome);
            comm.Parameters.AddWithValue("@QtdDependentes", funcionario.Nome);
            comm.Parameters.AddWithValue("@DataAdmissao", funcionario.Nome);
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
        public void delete(Cl_funcionario funcionario)
        {
            //Abro conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "DELETE FROM tbFuncionarios where cpf=@cpf";
            comm.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            //Executo comando
            comm.ExecuteNonQuery(); //non query, pois não retorna row
            //Fecho Conexao
            connection.Close();
        }

        public void update(Cl_funcionario funcionario)
        {
            //Abre Conexao
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand comm = connection.CreateCommand();
            //Executo comando de update
            comm.CommandText = "UPDATE tbFuncionsarios SET nome=@nome, CPF=@CPF, DataNascimento=@DataNasc,Endereco=@endereco,Cidade=@Cidade," +
                "Cargo=@Cargo,Salario=@Salario,Dependentes=@Dependentes,QtdDependentes=@QtdDependentes,DataAdmissao=@DataAdmissao where CPF=@CPF";
            //Valores parametrizados
            comm.Parameters.AddWithValue("@Nome", funcionario.Nome);
            comm.Parameters.AddWithValue("@CPF", funcionario.Nome);
            comm.Parameters.AddWithValue("@RG", funcionario.Nome);
            comm.Parameters.AddWithValue("@DataNasc", funcionario.Nome);
            comm.Parameters.AddWithValue("@Endereco", funcionario.Nome);
            comm.Parameters.AddWithValue("@Cidade", funcionario.Nome);
            comm.Parameters.AddWithValue("@Cargo", funcionario.Nome);
            comm.Parameters.AddWithValue("@Salario", funcionario.Nome);
            comm.Parameters.AddWithValue("@Dependentes", funcionario.Nome);
            comm.Parameters.AddWithValue("@QtdDependentes", funcionario.Nome);
            comm.Parameters.AddWithValue("@DataAdmissao", funcionario.Nome);
            //Executo o SQL
            comm.ExecuteNonQuery();  //non query, pois não retorna row
            //Fecha Conexao
            connection.Close();
        }       
    }
}
