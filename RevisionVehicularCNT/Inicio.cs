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
    public partial class Inicio : MetroForm
    {
        public Inicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            this.Opacity = this.Opacity + .02;
            if (circularProgressBar1.Value < circularProgressBar1.Maximum)
            {
                circularProgressBar1.Value = circularProgressBar1.Value + 1;
            }
            else
            {            
                timer1.Stop();
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
