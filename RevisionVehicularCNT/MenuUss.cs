﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionVehicularCNT
{
    public partial class MenuUss : Form
    {

        public MenuUss()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if(this.Panelcontenedor.Controls.Count > 0)
                this.Panelcontenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panelcontenedor.Controls.Add(fh);
            this.Panelcontenedor.Tag = fh;
            fh.Show();
        }
        private void RUR_Click(object sender, EventArgs e)
        {
        }

        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new Logos());
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
            tmFecha.Start();
            MenuUsuarios.IsMainMenu = true;
        }

        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Pacientes his = new Pacientes();
            //his.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(his);
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
                pictureBox2.Image = global::RevisionVehicularCNT.Properties.Resources.menu;
                lblHora.Visible = false;
                lbFecha.Visible = false;
            }
            else
            {
                MenuVertical.Width = 250;
                pictureBox2.Image = global::RevisionVehicularCNT.Properties.Resources.menu1;
                lblHora.Visible = true;
                lbFecha.Visible = true;
            }
        }

        private void tmFecha_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ubatéToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MenuNodos_Opening(object sender, CancelEventArgs e)
        {

        }

        private void zipaquiráToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Riesgo ries = new Riesgo();
            //ries.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(ries);
            ////this.Dispose();
            ////Riesgo r = new Riesgo();
            ////r.Show();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prioridad prio = new Prioridad();
            //prio.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(prio);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuUsuarios.Show(button10, button10.Width, 0);
        }

        private void MenuNodos_Click(object sender, EventArgs e)
        {
            
        }

        private void Pruebaa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void MenuNodos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void MenuNodos_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
