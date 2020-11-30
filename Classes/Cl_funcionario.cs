using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTruck
{
    class Cl_funcionario
    {
        string nome, dataNasc, endereco, cidade, cargo, dependentes, rg;
        int cpf,qtdDependentes,salario;

        public Cl_funcionario(string nome, string dataNasc, string endereco, string cidade, string cargo, string dependentes, string rg, int cpf, int qtdDependentes, int salario)
        {
            this.Nome = nome;
            this.DataNasc = dataNasc;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Cargo = cargo;
            this.Dependentes = dependentes;
            this.Rg = rg;
            this.Cpf = cpf;
            this.QtdDependentes = qtdDependentes;
            this.Salario = salario;
        }

        public string Nome { get => nome; set => nome = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Dependentes { get => dependentes; set => dependentes = value; }
        public string Rg { get => rg; set => rg = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public int QtdDependentes { get => qtdDependentes; set => qtdDependentes = value; }
        public int Salario { get => salario; set => salario = value; }
    }
}
