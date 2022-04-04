using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionVehicularCNT

{
    public partial class ConsultarPersona : MetroForm
    {
        public ConsultarPersona(String Documento)
        {
            InitializeComponent();
            txt_patente.Text = Documento;
        }

        private void ConsultarPaciente_Load(object sender, EventArgs e)
        {
            buscarlictotal(txt_patente.Text);
        }
        private void buscarlictotal(String patente)
        {
            if (patente.Equals(""))
            {
                patente = "%";
            }

            String busqueda = "select * from Persona where Identifacion like '" + patente + "%' ; ";
            SqlCommand comando = new SqlCommand(busqueda, basededatos.ObtenerConexion());
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            int num = dg_consulta.Rows.Count;
            lb_total.Text = num.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            buscarlictotal(txt_patente.Text);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (dg_consulta.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txt_docpaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarlictotal(txt_patente.Text);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            exportExcel expor = new exportExcel();
            expor.exportaraexcel(dg_consulta);
        }
    }
}
