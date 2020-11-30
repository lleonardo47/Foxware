using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTruck
{
    class Cl_veiculo
    {
        string tipo,placa,marca,modelo;
        int anomodelo;

        public Cl_veiculo(string tipo, string placa, string marca, string modelo, int anomodelo)
        {
            this.Tipo = tipo;
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anomodelo = anomodelo;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Anomodelo { get => anomodelo; set => anomodelo = value; }
    }
}
