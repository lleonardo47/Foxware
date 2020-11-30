using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTruck
{
    class Cl_estoque
    {
        string nome,descricao,validade;
        float valor;

        public Cl_estoque(string nome, string descricao, string validade, float valor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Validade = validade;
            this.Valor = valor;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Validade { get => validade; set => validade = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
