
namespace RevisionVehicularCNT
{
    partial class Revision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bt_nuevo = new MetroFramework.Controls.MetroButton();
            this.bt_guardar = new MetroFramework.Controls.MetroButton();
            this.bt_editar = new MetroFramework.Controls.MetroButton();
            this.bt_eliminar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_vehiculo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_observaciones = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_persona = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lb_id = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cb_estado = new MetroFramework.Controls.MetroComboBox();
            this.dt_fecha = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Location = new System.Drawing.Point(368, 397);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(71, 28);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Revisiones";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_nuevo.Location = new System.Drawing.Point(240, 397);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(58, 28);
            this.bt_nuevo.TabIndex = 7;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseSelectable = true;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_guardar.Location = new System.Drawing.Point(304, 397);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(58, 28);
            this.bt_guardar.TabIndex = 5;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseSelectable = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.Location = new System.Drawing.Point(445, 397);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(58, 28);
            this.bt_editar.TabIndex = 8;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseSelectable = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_eliminar.Location = new System.Drawing.Point(509, 397);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(58, 28);
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(29, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Patente";
            // 
            // txt_vehiculo
            // 
            this.txt_vehiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_vehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_vehiculo.CustomButton.Image = null;
            this.txt_vehiculo.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txt_vehiculo.CustomButton.Name = "";
            this.txt_vehiculo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_vehiculo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_vehiculo.CustomButton.TabIndex = 1;
            this.txt_vehiculo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_vehiculo.CustomButton.UseSelectable = true;
            this.txt_vehiculo.CustomButton.Visible = false;
            this.txt_vehiculo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_vehiculo.Lines = new string[0];
            this.txt_vehiculo.Location = new System.Drawing.Point(117, 108);
            this.txt_vehiculo.MaxLength = 32767;
            this.txt_vehiculo.Name = "txt_vehiculo";
            this.txt_vehiculo.PasswordChar = '\0';
            this.txt_vehiculo.ReadOnly = true;
            this.txt_vehiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vehiculo.SelectedText = "";
            this.txt_vehiculo.SelectionLength = 0;
            this.txt_vehiculo.SelectionStart = 0;
            this.txt_vehiculo.ShortcutsEnabled = true;
            this.txt_vehiculo.Size = new System.Drawing.Size(228, 23);
            this.txt_vehiculo.TabIndex = 0;
            this.txt_vehiculo.UseSelectable = true;
            this.txt_vehiculo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_vehiculo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(425, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 25);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Estado";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(338, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 25);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Observaciones";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_observaciones.CustomButton.Image = null;
            this.txt_observaciones.CustomButton.Location = new System.Drawing.Point(592, 1);
            this.txt_observaciones.CustomButton.Name = "";
            this.txt_observaciones.CustomButton.Size = new System.Drawing.Size(155, 155);
            this.txt_observaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_observaciones.CustomButton.TabIndex = 1;
            this.txt_observaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_observaciones.CustomButton.UseSelectable = true;
            this.txt_observaciones.CustomButton.Visible = false;
            this.txt_observaciones.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_observaciones.Lines = new string[0];
            this.txt_observaciones.Location = new System.Drawing.Point(29, 234);
            this.txt_observaciones.MaxLength = 999;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.PasswordChar = '\0';
            this.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_observaciones.SelectedText = "";
            this.txt_observaciones.SelectionLength = 0;
            this.txt_observaciones.SelectionStart = 0;
            this.txt_observaciones.ShortcutsEnabled = true;
            this.txt_observaciones.Size = new System.Drawing.Size(748, 157);
            this.txt_observaciones.TabIndex = 4;
            this.txt_observaciones.UseSelectable = true;
            this.txt_observaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_observaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(425, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 25);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Persona";
            // 
            // txt_persona
            // 
            this.txt_persona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_persona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_persona.CustomButton.Image = null;
            this.txt_persona.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txt_persona.CustomButton.Name = "";
            this.txt_persona.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_persona.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_persona.CustomButton.TabIndex = 1;
            this.txt_persona.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_persona.CustomButton.UseSelectable = true;
            this.txt_persona.CustomButton.Visible = false;
            this.txt_persona.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_persona.Lines = new string[0];
            this.txt_persona.Location = new System.Drawing.Point(513, 110);
            this.txt_persona.MaxLength = 32767;
            this.txt_persona.Name = "txt_persona";
            this.txt_persona.PasswordChar = '\0';
            this.txt_persona.ReadOnly = true;
            this.txt_persona.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_persona.SelectedText = "";
            this.txt_persona.SelectionLength = 0;
            this.txt_persona.SelectionStart = 0;
            this.txt_persona.ShortcutsEnabled = true;
            this.txt_persona.Size = new System.Drawing.Size(228, 23);
            this.txt_persona.TabIndex = 3;
            this.txt_persona.UseSelectable = true;
            this.txt_persona.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_persona.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(29, 168);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 25);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Fecha";
            // 
            // lb_id
            // 
            this.lb_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_id.AutoSize = true;
            this.lb_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_id.Location = new System.Drawing.Point(388, 13);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 25);
            this.lb_id.TabIndex = 27;
            this.lb_id.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::RevisionVehicularCNT.Properties.Resources.coche__1_;
            this.pictureBox1.Location = new System.Drawing.Point(351, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::RevisionVehicularCNT.Properties.Resources.personas__1_;
            this.pictureBox2.Location = new System.Drawing.Point(747, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.ItemHeight = 23;
            this.cb_estado.Items.AddRange(new object[] {
            "Aprobado",
            "En proceso",
            "Rechazado"});
            this.cb_estado.Location = new System.Drawing.Point(513, 164);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(228, 29);
            this.cb_estado.TabIndex = 118;
            this.cb_estado.UseSelectable = true;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.Location = new System.Drawing.Point(117, 164);
            this.dt_fecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(228, 29);
            this.dt_fecha.TabIndex = 119;
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_persona);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_vehiculo);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_eliminar);
            this.Name = "Revision";
            this.Text = "Revisión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton bt_nuevo;
        private MetroFramework.Controls.MetroButton bt_guardar;
        private MetroFramework.Controls.MetroButton bt_editar;
        private MetroFramework.Controls.MetroButton bt_eliminar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_vehiculo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_observaciones;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_persona;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lb_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cb_estado;
        private MetroFramework.Controls.MetroDateTime dt_fecha;
    }
}