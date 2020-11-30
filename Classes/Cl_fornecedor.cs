using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTruck
{
    class Cl_fornecedor
    {
        string nomeFornecedor;
        int CNPJ;

        public Cl_fornecedor(string nomeFornecedor, int cNPJ)
        {
            this.NomeFornecedor = nomeFornecedor;
            CNPJ1 = cNPJ;
        }

        public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }
        public int CNPJ1 { get => CNPJ; set => CNPJ = value; }
    }
}
