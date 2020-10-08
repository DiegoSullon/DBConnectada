using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataSiConectada
{
    class Conexion
    {

        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = "Data Source=DESKTOP-FV5LUU9\\SQLEXPRESS; Initial Catalog=DBCliente2; Integrated Security=true";
                MessageBox.Show("Conectando " + sqlConnection);
                return sqlConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error conexion");
                return null;
            }

        }
    }
}
