namespace main
{
    partial class PerfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilAdmin));
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
            this.btnactualizaruser = new System.Windows.Forms.Button();
            this.btnlimpiaruser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbfuerte
            // 
            this.lbfuerte.AutoSize = true;
            this.lbfuerte.Location = new System.Drawing.Point(49, 317);
            this.lbfuerte.Name = "lbfuerte";
            this.lbfuerte.Size = new System.Drawing.Size(0, 13);
            this.lbfuerte.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Datos de usuario";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(311, 269);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(182, 20);
            this.txtconfirm.TabIndex = 27;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(53, 269);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(184, 20);
            this.txtpass.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nueva contraseña:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(309, 157);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.ReadOnly = true;
            this.txtcorreo.Size = new System.Drawing.Size(184, 20);
            this.txtcorreo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Correo electrónico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre de usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(52, 157);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(185, 20);
            this.txtusuario.TabIndex = 20;
            // 
            // btnactualizaruser
            // 
            this.btnactualizaruser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnactualizaruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizaruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizaruser.ForeColor = System.Drawing.Color.White;
            this.btnactualizaruser.Location = new System.Drawing.Point(137, 371);
            this.btnactualizaruser.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizaruser.Name = "btnactualizaruser";
            this.btnactualizaruser.Size = new System.Drawing.Size(100, 28);
            this.btnactualizaruser.TabIndex = 18;
            this.btnactualizaruser.Text = "Actualizar";
            this.btnactualizaruser.UseVisualStyleBackColor = false;
            this.btnactualizaruser.Click += new System.EventHandler(this.btnactualizaruser_Click);
            // 
            // btnlimpiaruser
            // 
            this.btnlimpiaruser.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlimpiaruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiaruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiaruser.ForeColor = System.Drawing.Color.White;
            this.btnlimpiaruser.Location = new System.Drawing.Point(308, 371);
            this.btnlimpiaruser.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiaruser.Name = "btnlimpiaruser";
            this.btnlimpiaruser.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiaruser.TabIndex = 19;
            this.btnlimpiaruser.Text = "Limpiar";
            this.btnlimpiaruser.UseVisualStyleBackColor = false;
            this.btnlimpiaruser.Click += new System.EventHandler(this.btnlimpiaruser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::main.Properties.Resources.info;
            this.pictureBox2.Location = new System.Drawing.Point(244, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PerfilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(576, 436);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbfuerte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnactualizaruser);
            this.Controls.Add(this.btnlimpiaruser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PerfilAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Market";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PerfilAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbfuerte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnactualizaruser;
        private System.Windows.Forms.Button btnlimpiaruser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}