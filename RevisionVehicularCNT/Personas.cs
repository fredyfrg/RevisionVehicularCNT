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
    public partial class Personas : MetroForm
    {
        public Personas()
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
            txt_documento.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            bt_guardar.Enabled = true;
            bt_editar.Enabled = false;
            bt_eliminar.Enabled = false;
            txt_documento.ReadOnly = false;
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txt_documento.Text)) && (!string.IsNullOrEmpty(txt_nombre.Text)) && (!string.IsNullOrEmpty(txt_apellido.Text)))
                {
                    int status = basededatos.Insertar_Persona(txt_documento.Text,txt_nombre.Text,txt_apellido.Text);
                    if (status == 1)
                    {
                        MessageBox.Show("Se ha registrado correctamente la persona", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("No se ha registrado la persona", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String validacion = "Ingrese";
                    if (!string.IsNullOrEmpty(txt_documento.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el número de documento, ";
                    }
                    if (!string.IsNullOrEmpty(txt_nombre.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el nombre, ";
                    }
                    if (!string.IsNullOrEmpty(txt_apellido.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el apellido, ";
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
            ConsultarPersona consul = new ConsultarPersona(txt_documento.Text);
            consul.ShowDialog();
            if (consul.DialogResult == DialogResult.OK)
            {
                String idpersona = consul.dg_consulta.Rows[consul.dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(String.Format("SELECT * FROM persona " +
                    "where id='" + idpersona + "';"), basededatos.ObtenerConexion());
                SqlDataReader MyReader = comando.ExecuteReader();
                while (MyReader.Read())
                {
                    txt_documento.Text = MyReader["Identifacion"].ToString();
                    txt_nombre.Text = MyReader["Nombre"].ToString();
                    txt_apellido.Text = MyReader["Apellido"].ToString();
                }
                lb_id.Text = idpersona;
                this.bt_guardar.Enabled = false;
                txt_documento.ReadOnly = true;
                this.bt_editar.Enabled = true;
                this.bt_eliminar.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txt_documento.Text)) && (!string.IsNullOrEmpty(txt_nombre.Text)) && (!string.IsNullOrEmpty(txt_apellido.Text)))
                {

                    int status = basededatos.editarPersona(txt_documento.Text, txt_nombre.Text, txt_apellido.Text,lb_id.Text);
                    if (status == 1)
                    {
                        MessageBox.Show("Se ha editado correctamente la persona", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("No se ha editado la persona", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String validacion = "Ingrese";
                    if (!string.IsNullOrEmpty(txt_documento.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el número de documento, ";
                    }
                    if (!string.IsNullOrEmpty(txt_nombre.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el nombre, ";
                    }
                    if (!string.IsNullOrEmpty(txt_apellido.Text))
                    {
                    }
                    else
                    {
                        validacion += "" + " el apellido, ";
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
