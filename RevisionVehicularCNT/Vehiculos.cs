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
    public partial class Vehiculos : MetroForm
    {
        public Vehiculos()
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        String idpersona = "0";
        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            lb_id.Text = "";
            txt_patente.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_persona.Text = "";
            txt_año.Text = "";
            bt_guardar.Enabled = true;
            bt_editar.Enabled = false;
            bt_eliminar.Enabled = false;
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txt_patente.Text)) && (!string.IsNullOrEmpty(txt_marca.Text)) && (!string.IsNullOrEmpty(txt_modelo.Text)) && (!string.IsNullOrEmpty(txt_año.Text)) && (!string.IsNullOrEmpty(txt_persona.Text)))
                {

                    int status = basededatos.Insertar_Vehiculo(txt_marca.Text,txt_modelo.Text,txt_patente.Text,txt_año.Text,idpersona);
                    if (status == 1)
                    {
                        MessageBox.Show("Se ha registrado correctamente el vehículo", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("No se ha registrado el vehículo", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String validacion = "Ingrese";
                    if (!string.IsNullOrEmpty(txt_patente.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el número de patente, ";
                    }
                    if (!string.IsNullOrEmpty(txt_marca.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " la marca, ";
                    }
                    if (!string.IsNullOrEmpty(txt_modelo.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el modelo, ";
                    }
                    if (!string.IsNullOrEmpty(txt_persona.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " la persona, ";
                    }
                    if (!string.IsNullOrEmpty(txt_año.Text))
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
            ConsultarVehiculo consul = new ConsultarVehiculo(txt_patente.Text);
            consul.ShowDialog();
            if (consul.DialogResult == DialogResult.OK)
            {
                String idvehiculo = consul.dg_consulta.Rows[consul.dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(String.Format("SELECT * FROM vehiculo " +
                    "where id='" + idvehiculo + "';"), basededatos.ObtenerConexion());
                SqlDataReader MyReader = comando.ExecuteReader();
                while (MyReader.Read())
                {
                    txt_patente.Text = MyReader["Patente"].ToString();
                    txt_marca.Text = MyReader["Marca"].ToString();
                    txt_modelo.Text = MyReader["Modelo"].ToString();
                    txt_año.Text = MyReader["Año"].ToString();
                    idpersona = MyReader["PersonaId"].ToString();
                }
                lb_id.Text = idvehiculo;
                txt_persona.Text = basededatos.Consultanombrepersona(idpersona);
                this.bt_guardar.Enabled = false;
                txt_patente.ReadOnly = true;
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
                idpersona= consul.dg_consulta.Rows[consul.dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();                
                txt_persona.Text = basededatos.Consultanombrepersona(idpersona);
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txt_patente.Text)) && (!string.IsNullOrEmpty(txt_marca.Text)) && (!string.IsNullOrEmpty(txt_modelo.Text)) && (!string.IsNullOrEmpty(txt_año.Text)) && (!string.IsNullOrEmpty(txt_persona.Text)))
                {

                    int status = basededatos.editarVehiculo(txt_marca.Text, txt_modelo.Text, txt_patente.Text, txt_año.Text, idpersona,lb_id.Text);
                    if (status == 1)
                    {
                        MessageBox.Show("Se ha editado correctamente el vehículo", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("No se ha editado el vehículo", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String validacion = "Ingrese";
                    if (!string.IsNullOrEmpty(txt_patente.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el número de patente, ";
                    }
                    if (!string.IsNullOrEmpty(txt_marca.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " la marca, ";
                    }
                    if (!string.IsNullOrEmpty(txt_modelo.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el modelo, ";
                    }
                    if (!string.IsNullOrEmpty(txt_persona.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " la persona, ";
                    }
                    if (!string.IsNullOrEmpty(txt_año.Text))
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
    }
}
