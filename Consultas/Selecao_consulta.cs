using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace FoxTruck
{
    public partial class Selecao_consulta : MaterialForm
    {
        public Selecao_consulta()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
            string tipo_consulta;
            tipo_consulta = cb_consulta.Text;
            switch (tipo_consulta)
            {
                case "Cliente":
                    Cliente_consulta tela_cliente = new Cliente_consulta();
                    tela_cliente.Show();
                    break;
                case "Estoque":
                    Estoque_consulta estoque = new Estoque_consulta();
                    estoque.Show();
                    break;

                case "Funcionário":
                    Funcionario_consulta funcionario = new Funcionario_consulta();
                    funcionario.Show();
                    break;
                case "Ordem de serviço":
                    OrdemServico_consulta ordemServico = new OrdemServico_consulta();
                    ordemServico.Show();
                    break;
                case "Veículo":
                    Veiculo_consulta veiculo = new Veiculo_consulta();
                    veiculo.Show();
                    break;
            }
        }
    }
}
