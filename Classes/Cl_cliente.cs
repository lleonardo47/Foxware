using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTruck
{
    class Cl_cliente
    {
        //Declaração de variaveis, encapsulamento e construtor.
        /*endereco = "", bairro = "",*/
        /*estado = "",*/
        string nome_razao = "", cidade = "" ;
        int cpf_cnpj = 0, idCliente = 0, idveiculo = 0;

        public Cl_cliente(string nome_razao, string cidade, int cpf_cnpj,int idveiculo)
        {
            this.nome_razao = nome_razao;
            this.cidade = cidade;
            this.cpf_cnpj = cpf_cnpj;
            this.idveiculo = idveiculo;
        }

        public string Nome_razao { get => nome_razao; set => nome_razao = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public int Idveiculo { get => idveiculo; set => idveiculo = value; }

    }
        
}
