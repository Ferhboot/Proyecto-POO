namespace main
{
    partial class Perfil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.btnactualizaruser = new System.Windows.Forms.Button();
            this.btnlimpiaruser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbfuerte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbdep = new System.Windows.Forms.ComboBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpostal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnactualizarperso = new System.Windows.Forms.Button();
            this.btnlimpiarperso = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnactualizaruser
            // 
            this.btnactualizaruser.Location = new System.Drawing.Point(142, 370);
            this.btnactualizaruser.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizaruser.Name = "btnactualizaruser";
            this.btnactualizaruser.Size = new System.Drawing.Size(100, 28);
            this.btnactualizaruser.TabIndex = 0;
            this.btnactualizaruser.Text = "Actualizar";
            this.btnactualizaruser.UseVisualStyleBackColor = true;
            this.btnactualizaruser.Click += new System.EventHandler(this.btnactualizaruser_Click);
            // 
            // btnlimpiaruser
            // 
            this.btnlimpiaruser.Location = new System.Drawing.Point(313, 370);
            this.btnlimpiaruser.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiaruser.Name = "btnlimpiaruser";
            this.btnlimpiaruser.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiaruser.TabIndex = 1;
            this.btnlimpiaruser.Text = "Limpiar";
            this.btnlimpiaruser.UseVisualStyleBackColor = true;
            this.btnlimpiaruser.Click += new System.EventHandler(this.btnlimpiaruser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 479);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.lbfuerte);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtconfirm);
            this.tabPage1.Controls.Add(this.txtpass);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcorreo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtusuario);
            this.tabPage1.Controls.Add(this.btnactualizaruser);
            this.tabPage1.Controls.Add(this.btnlimpiaruser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(557, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::main.Properties.Resources.info;
            this.pictureBox2.Location = new System.Drawing.Point(249, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Su contraseña debe tener al menos:\r\n1 Mayúscula\r\n1 Número\r\n8 caracteres como míni" +
        "mo");
            // 
            // lbfuerte
            // 
            this.lbfuerte.AutoSize = true;
            this.lbfuerte.Location = new System.Drawing.Point(54, 316);
            this.lbfuerte.Name = "lbfuerte";
            this.lbfuerte.Size = new System.Drawing.Size(0, 16);
            this.lbfuerte.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datos de usuario";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(316, 268);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(182, 22);
            this.txtconfirm.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(58, 268);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(184, 22);
            this.txtpass.TabIndex = 8;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva contraseña:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(314, 156);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.ReadOnly = true;
            this.txtcorreo.Size = new System.Drawing.Size(184, 22);
            this.txtcorreo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo electrónico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(57, 156);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(185, 22);
            this.txtusuario.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbdep);
            this.tabPage2.Controls.Add(this.txttelefono);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtpostal);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtciudad);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtdireccion);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtnombre);
            this.tabPage2.Controls.Add(this.btnactualizarperso);
            this.tabPage2.Controls.Add(this.btnlimpiarperso);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(557, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Datos personales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbdep
            // 
            this.cmbdep.FormattingEnabled = true;
            this.cmbdep.Items.AddRange(new object[] {
            "Ahuachapán",
            "Cabañas",
            "Chalatenango",
            "Cuscatlán",
            "La Libertad",
            "La Paz",
            "La Unión",
            "Morazán",
            "San Miguel",
            "San Salvador",
            "San Vicente",
            "Santa Ana",
            "Sonsonate",
            "Usulután"});
            this.cmbdep.Location = new System.Drawing.Point(60, 179);
            this.cmbdep.Name = "cmbdep";
            this.cmbdep.Size = new System.Drawing.Size(182, 24);
            this.cmbdep.TabIndex = 30;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(317, 314);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(182, 22);
            this.txttelefono.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 283);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Teléfono:";
            // 
            // txtpostal
            // 
            this.txtpostal.Location = new System.Drawing.Point(60, 314);
            this.txtpostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtpostal.Name = "txtpostal";
            this.txtpostal.Size = new System.Drawing.Size(182, 22);
            this.txtpostal.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 283);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Código postal:";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(317, 179);
            this.txtciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(182, 22);
            this.txtciudad.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Municipio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Datos de personales";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(60, 246);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(439, 22);
            this.txtdireccion.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Departamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(60, 110);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(322, 22);
            this.txtnombre.TabIndex = 13;
            // 
            // btnactualizarperso
            // 
            this.btnactualizarperso.Location = new System.Drawing.Point(142, 378);
            this.btnactualizarperso.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizarperso.Name = "btnactualizarperso";
            this.btnactualizarperso.Size = new System.Drawing.Size(100, 28);
            this.btnactualizarperso.TabIndex = 11;
            this.btnactualizarperso.Text = "Actualizar";
            this.btnactualizarperso.UseVisualStyleBackColor = true;
            this.btnactualizarperso.Click += new System.EventHandler(this.btnactualizarperso_Click);
            // 
            // btnlimpiarperso
            // 
            this.btnlimpiarperso.Location = new System.Drawing.Point(304, 378);
            this.btnlimpiarperso.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiarperso.Name = "btnlimpiarperso";
            this.btnlimpiarperso.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiarperso.TabIndex = 12;
            this.btnlimpiarperso.Text = "Limpiar";
            this.btnlimpiarperso.UseVisualStyleBackColor = true;
            this.btnlimpiarperso.Click += new System.EventHandler(this.btnlimpiarperso_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 477);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Perfil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnactualizaruser;
        private System.Windows.Forms.Button btnlimpiaruser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbfuerte;
        private System.Windows.Forms.ComboBox cmbdep;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpostal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnactualizarperso;
        private System.Windows.Forms.Button btnlimpiarperso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}