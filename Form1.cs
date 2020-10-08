using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSiConectada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public void ListaCliente()
        {
            //dgv1.Columns.Clear();
            BindingSource datosEnlazados = new BindingSource();
            List<Cliente> lista = MostrarDatos.listarCliente();
            datosEnlazados.DataSource = lista;
            dgv1.DataSource = datosEnlazados;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ListaCliente();
        }
    }
}
