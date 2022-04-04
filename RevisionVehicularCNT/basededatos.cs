using System;
using System.Collections.Generic;
using System.Data;
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
        public static String ConexionSQLMaster { get; set; }

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
                ConexionSQLMaster = ConexionSQL.Replace("CNTRevision", "Master");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error archivo conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static String ConsultarBD(String nombrebd)
        {
            String status = "0";
            try
            {
                SqlCommand comando = new SqlCommand(String.Format("select name from sys.sysdatabases where name='{0}';", nombrebd), basededatos.ObtenerConexion());
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    status = leer["name"].ToString();
                }
            }
            catch
            {
                status = "0";
            }
            return status;
        }

        public static int Insertar_Vehiculo(String Marca, String Modelo, String Patente, String Año, String PersonaId)
        {
            int registro;
            try
            {
                SqlCommand cmd = new SqlCommand("Insertar_Vehiculo", basededatos.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@Modelo", Modelo);
                cmd.Parameters.AddWithValue("@Patente", Patente);
                cmd.Parameters.AddWithValue("@Año", Año);
                cmd.Parameters.AddWithValue("@PersonaId", PersonaId);
                registro = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
                MessageBox.Show(ex.Message);
            }
            return registro;
        }
    }
}
