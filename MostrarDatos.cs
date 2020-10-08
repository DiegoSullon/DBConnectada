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
    public class MostrarDatos
    {
        public static List<Cliente> listarCliente()
        {
            SqlCommand cmd = null;

            List<Cliente> lista = new List<Cliente>();

            try
            {
                SqlConnection cn = Conexion.Conectar();
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Cliente cli = new Cliente();
                    cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    cli.razonSocial = Convert.ToString(dr["razonSocial"]);
                    cli.idTipoCliente = Convert.ToInt32(dr["idTipoCliente"]);
                    cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    lista.Add(cli);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show("Error listar cliente");
           
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;

        }
    }
}