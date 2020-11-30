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
using System.Data.SqlClient;

namespace FoxTruck
{
    public partial class Cliente_consulta : MaterialForm
    {

        public Cliente_consulta()
        {
            InitializeComponent();


            string connstring = "Server=DESKTOP-ECQ57U5;Database=FOXTRUCK;User Id=admin;Password=admin;";
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM tbClientes", connection);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            data_cliente.DataSource = dt;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {    
            Cl_cliente cl_cliente = new Cl_cliente(txt_nome_razao.Text,txt_cidade.Text,Convert.ToInt32(txt_cpf_cnpj.Text),
                                                   Convert.ToInt32(txt_placa.Text));
            Cl_clienteDAO cliente = new Cl_clienteDAO();
            cliente.create(cl_cliente);
            
        }
    }
}
