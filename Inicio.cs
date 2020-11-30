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
    public partial class Inicio : MaterialForm
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Selecao_consulta selecao = new Selecao_consulta();
            selecao.Show();
        }

    }
}
