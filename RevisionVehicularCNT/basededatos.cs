using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionVehicularCNT
{
    class basededatos
    {
        public static String ConexionSQL { get; set; }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection(ConexionSQL);
            conectar.Open();
            return conectar;
        }

        public static void leerconexion()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string fullFilePath = path + "conexion.txt";
                StreamReader con = new StreamReader(fullFilePath);
                ConexionSQL = con.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error archivo conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
