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
    public partial class Revision : MetroForm
    {
        public Revision()
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        int idpersona = 0;
        int idvehiculo = 0;
        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            lb_id.Text = "";
            txt_vehiculo.Text = "";
            txt_persona.Text = "";
            txt_observaciones.Text = "";
            bt_guardar.Enabled = true;
            bt_editar.Enabled = false;
            bt_eliminar.Enabled = false;
            cb_estado.SelectedIndex = -1;
        }


        private void bt_guardar_Click(object sender, EventArgs e)
        {            
            try
            {
                if ((!string.IsNullOrEmpty(txt_vehiculo.Text)) && (!string.IsNullOrEmpty(txt_observaciones.Text)) && (!string.IsNullOrEmpty(txt_persona.Text)))
                {
                    if (cb_estado.SelectedIndex == -1)
                    {
                        cb_estado.SelectedIndex = 1;
                    }
                    int status = basededatos.Insertar_Revision(idvehiculo,cb_estado.SelectedIndex,txt_observaciones.Text,idpersona,dt_fecha.Value.ToShortDateString());
                    if (status == 1)
                    {
                        MessageBox.Show("Se ha registrado correctamente la revisión", "Revisión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("No se ha registrado la revisión", "Revisión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String validacion = "Ingrese";
                    if (!string.IsNullOrEmpty(txt_vehiculo.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el número de patente, ";
                    }
                    if (!string.IsNullOrEmpty(txt_persona.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " la persona, ";
                    }
                    if (!string.IsNullOrEmpty(txt_observaciones.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el año, ";
                    }
                    MessageBox.Show(validacion, "Error De Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error De Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            int estado = 0;
            ConsultarRevision consul = new ConsultarRevision(txt_vehiculo.Text);
            consul.ShowDialog();
            if (consul.DialogResult == DialogResult.OK)
            {
                String idrevision = consul.dg_consulta.Rows[consul.dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(String.Format("SELECT * FROM revision " +
                    "where id='" + idrevision + "';"), basededatos.ObtenerConexion());
                SqlDataReader MyReader = comando.ExecuteReader();
                while (MyReader.Read())
                {
                    idvehiculo = Convert.ToInt32(MyReader["VehiculoId"].ToString());
                    idpersona = Convert.ToInt32(MyReader["PersonaId"].ToString());
                    txt_observaciones.Text = MyReader["Observaciones"].ToString();
                    dt_fecha.Text = MyReader["Fecha_revision"].ToString();
                    cb_estado.SelectedIndex = Convert.ToInt32(MyReader["Aprobado"].ToString());
                }
                lb_id.Text = idrevision;
                txt_persona.Text = basededatos.Consultanombrepersona2(idpersona);
                txt_vehiculo.Text = basededatos.Consultarvehiculo2(idvehiculo);
                this.bt_guardar.Enabled = false;
                txt_vehiculo.ReadOnly = true;
                this.bt_editar.Enabled = true;
                this.bt_eliminar.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConsultarPersona consul = new ConsultarPersona("");
            consul.ShowDialog();
            if (consul.DialogResult == DialogResult.OK)
            {
                idpersona= Convert.ToInt32(consul.dg_consulta.Rows[consul.dg_consulta.CurrentRow.Index].Cells[0].Value.ToString());                
                txt_persona.Text = basededatos.Consultanombrepersona2(idpersona);
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txt_vehiculo.Text)) && (!string.IsNullOrEmpty(txt_observaciones.Text)) && (!string.IsNullOrEmpty(txt_persona.Text)))
                {
                    if (cb_estado.SelectedIndex == -1)
                    {
                        cb_estado.SelectedIndex = 1;
                    }
                    int status = basededatos.editarRevision(idvehiculo, cb_estado.SelectedIndex, txt_observaciones.Text, idpersona, dt_fecha.Value.ToShortDateString(), lb_id.Text);
                    if (status == 1)
                    {
                        MessageBox.Show("Se ha registrado correctamente la revisión", "Revisión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("No se ha registrado la revisión", "Revisión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String validacion = "Ingrese";
                    if (!string.IsNullOrEmpty(txt_vehiculo.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el número de patente, ";
                    }
                    if (!string.IsNullOrEmpty(txt_persona.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " la persona, ";
                    }
                    if (!string.IsNullOrEmpty(txt_observaciones.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el año, ";
                    }
                    MessageBox.Show(validacion, "Error De Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error De Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultarVehiculo consul = new ConsultarVehiculo("");
            consul.ShowDialog();
            if (consul.DialogResult == DialogResult.OK)
            {
                idvehiculo = Convert.ToInt32(consul.dg_consulta.Rows[consul.dg_consulta.CurrentRow.Index].Cells[0].Value.ToString());
                txt_vehiculo.Text = basededatos.Consultarvehiculo2(idvehiculo);
            }
        }
    }
}
