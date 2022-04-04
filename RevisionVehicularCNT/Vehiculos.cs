using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionVehicularCNT
{
    public partial class Vehículos : MetroForm
    {
        public Vehículos()
        {
            InitializeComponent();
        }

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
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
