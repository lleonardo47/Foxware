using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTruck
{
    class Cl_ordemServico
    {
        string  idFunc,idCliente,idServico,quantidade,dataEntrada,dataSaida;
        int numOS,valorTotal;

        public Cl_ordemServico(string idFunc, string idCliente, string idServico, string quantidade, string dataEntrada, string dataSaida, int numOS, int valorTotal)
        {
            this.IdFunc = idFunc;
            this.IdCliente = idCliente;
            this.IdServico = idServico;
            this.Quantidade = quantidade;
            this.DataEntrada = dataEntrada;
            this.DataSaida = dataSaida;
            this.NumOS = numOS;
            this.ValorTotal = valorTotal;
        }

        public string IdFunc { get => idFunc; set => idFunc = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdServico { get => idServico; set => idServico = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public int NumOS { get => numOS; set => numOS = value; }
        public int ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
