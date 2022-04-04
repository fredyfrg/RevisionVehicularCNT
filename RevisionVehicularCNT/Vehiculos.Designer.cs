
namespace RevisionVehicularCNT
{
    partial class Vehículos
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
            this.txt_patente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_modelo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_año = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_persona = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_marca = new MetroFramework.Controls.MetroTextBox();
            this.lb_id = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Location = new System.Drawing.Point(368, 368);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(71, 28);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Vehiculos";
            this.metroButton1.UseSelectable = true;
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_nuevo.Location = new System.Drawing.Point(240, 368);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(58, 28);
            this.bt_nuevo.TabIndex = 13;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseSelectable = true;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_guardar.Location = new System.Drawing.Point(304, 368);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(58, 28);
            this.bt_guardar.TabIndex = 12;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseSelectable = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.Location = new System.Drawing.Point(445, 368);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(58, 28);
            this.bt_editar.TabIndex = 15;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseSelectable = true;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_eliminar.Location = new System.Drawing.Point(509, 368);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(58, 28);
            this.bt_eliminar.TabIndex = 16;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(277, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Patente";
            // 
            // txt_patente
            // 
            this.txt_patente.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_patente.CustomButton.Image = null;
            this.txt_patente.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txt_patente.CustomButton.Name = "";
            this.txt_patente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_patente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_patente.CustomButton.TabIndex = 1;
            this.txt_patente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_patente.CustomButton.UseSelectable = true;
            this.txt_patente.CustomButton.Visible = false;
            this.txt_patente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_patente.Lines = new string[0];
            this.txt_patente.Location = new System.Drawing.Point(351, 99);
            this.txt_patente.MaxLength = 32767;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.PasswordChar = '\0';
            this.txt_patente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_patente.SelectedText = "";
            this.txt_patente.SelectionLength = 0;
            this.txt_patente.SelectionStart = 0;
            this.txt_patente.ShortcutsEnabled = true;
            this.txt_patente.Size = new System.Drawing.Size(155, 23);
            this.txt_patente.TabIndex = 17;
            this.txt_patente.UseSelectable = true;
            this.txt_patente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_patente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(461, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Modelo";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_modelo.CustomButton.Image = null;
            this.txt_modelo.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txt_modelo.CustomButton.Name = "";
            this.txt_modelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_modelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_modelo.CustomButton.TabIndex = 1;
            this.txt_modelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_modelo.CustomButton.UseSelectable = true;
            this.txt_modelo.CustomButton.Visible = false;
            this.txt_modelo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_modelo.Lines = new string[0];
            this.txt_modelo.Location = new System.Drawing.Point(549, 170);
            this.txt_modelo.MaxLength = 32767;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.PasswordChar = '\0';
            this.txt_modelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_modelo.SelectedText = "";
            this.txt_modelo.SelectionLength = 0;
            this.txt_modelo.SelectionStart = 0;
            this.txt_modelo.ShortcutsEnabled = true;
            this.txt_modelo.Size = new System.Drawing.Size(228, 23);
            this.txt_modelo.TabIndex = 19;
            this.txt_modelo.UseSelectable = true;
            this.txt_modelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_modelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(461, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 25);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Año";
            // 
            // txt_año
            // 
            this.txt_año.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_año.CustomButton.Image = null;
            this.txt_año.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txt_año.CustomButton.Name = "";
            this.txt_año.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_año.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_año.CustomButton.TabIndex = 1;
            this.txt_año.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_año.CustomButton.UseSelectable = true;
            this.txt_año.CustomButton.Visible = false;
            this.txt_año.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_año.Lines = new string[0];
            this.txt_año.Location = new System.Drawing.Point(549, 235);
            this.txt_año.MaxLength = 32767;
            this.txt_año.Name = "txt_año";
            this.txt_año.PasswordChar = '\0';
            this.txt_año.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_año.SelectedText = "";
            this.txt_año.SelectionLength = 0;
            this.txt_año.SelectionStart = 0;
            this.txt_año.ShortcutsEnabled = true;
            this.txt_año.Size = new System.Drawing.Size(228, 23);
            this.txt_año.TabIndex = 21;
            this.txt_año.UseSelectable = true;
            this.txt_año.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_año.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(29, 233);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 25);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Persona";
            // 
            // txt_persona
            // 
            this.txt_persona.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.txt_persona.Location = new System.Drawing.Point(117, 235);
            this.txt_persona.MaxLength = 32767;
            this.txt_persona.Name = "txt_persona";
            this.txt_persona.PasswordChar = '\0';
            this.txt_persona.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_persona.SelectedText = "";
            this.txt_persona.SelectionLength = 0;
            this.txt_persona.SelectionStart = 0;
            this.txt_persona.ShortcutsEnabled = true;
            this.txt_persona.Size = new System.Drawing.Size(228, 23);
            this.txt_persona.TabIndex = 23;
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
            this.metroLabel5.Size = new System.Drawing.Size(59, 25);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Marca";
            // 
            // txt_marca
            // 
            this.txt_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_marca.CustomButton.Image = null;
            this.txt_marca.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txt_marca.CustomButton.Name = "";
            this.txt_marca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_marca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_marca.CustomButton.TabIndex = 1;
            this.txt_marca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_marca.CustomButton.UseSelectable = true;
            this.txt_marca.CustomButton.Visible = false;
            this.txt_marca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_marca.Lines = new string[0];
            this.txt_marca.Location = new System.Drawing.Point(117, 170);
            this.txt_marca.MaxLength = 32767;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.PasswordChar = '\0';
            this.txt_marca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_marca.SelectedText = "";
            this.txt_marca.SelectionLength = 0;
            this.txt_marca.SelectionStart = 0;
            this.txt_marca.ShortcutsEnabled = true;
            this.txt_marca.Size = new System.Drawing.Size(228, 23);
            this.txt_marca.TabIndex = 25;
            this.txt_marca.UseSelectable = true;
            this.txt_marca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_marca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lb_id
            // 
            this.lb_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_id.AutoSize = true;
            this.lb_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_id.Location = new System.Drawing.Point(388, 13);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 25);
            this.lb_id.TabIndex = 27;
            this.lb_id.Text = ".";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::RevisionVehicularCNT.Properties.Resources.personas__1_;
            this.pictureBox2.Location = new System.Drawing.Point(351, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            // 
            // Vehículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_persona);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_patente);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_eliminar);
            this.Name = "Vehículos";
            this.Text = "Vehículos";
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
        private MetroFramework.Controls.MetroTextBox txt_patente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_modelo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_año;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_persona;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_marca;
        private MetroFramework.Controls.MetroLabel lb_id;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}