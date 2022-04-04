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
    public partial class ConsultarRevision : MetroForm
    {
        public ConsultarRevision(String Documento)
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
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

            String busqueda = "select Revision.Id,CONVERT(date,Revision.Fecha_revision) as Fecha, Vehiculo.Patente, Persona.Identifacion as 'Identificación', Persona.Nombre, Persona.Apellido,case when Revision.Aprobado = 0 then 'Aprobado' when Revision.Aprobado = 1 then 'En proceso' else 'Rechazado' end as Estado from Revision,Vehiculo,Persona where Vehiculo.Patente like '" + patente + "%' and Revision.VehiculoId=Vehiculo.Id and Revision.PersonaId=Persona.Id ; ";
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
