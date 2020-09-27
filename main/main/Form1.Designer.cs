namespace main
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btncuenta = new System.Windows.Forms.Button();
            this.btninvitado = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncuenta
            // 
            this.btncuenta.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btncuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncuenta.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncuenta.Location = new System.Drawing.Point(271, 286);
            this.btncuenta.Name = "btncuenta";
            this.btncuenta.Size = new System.Drawing.Size(105, 66);
            this.btncuenta.TabIndex = 0;
            this.btncuenta.Text = "Ingresar con mi cuenta";
            this.btncuenta.UseVisualStyleBackColor = false;
            this.btncuenta.Click += new System.EventHandler(this.btncuenta_Click);
            // 
            // btninvitado
            // 
            this.btninvitado.BackColor = System.Drawing.Color.Red;
            this.btninvitado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninvitado.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.btninvitado.Location = new System.Drawing.Point(463, 286);
            this.btninvitado.Name = "btninvitado";
            this.btninvitado.Size = new System.Drawing.Size(105, 66);
            this.btninvitado.TabIndex = 6;
            this.btninvitado.Text = "Ingresar como Invitado";
            this.btninvitado.UseVisualStyleBackColor = false;
            this.btninvitado.Click += new System.EventHandler(this.btninvitado_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.Color.Yellow;
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistro.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.Location = new System.Drawing.Point(72, 286);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(116, 66);
            this.btnregistro.TabIndex = 7;
            this.btnregistro.Text = "Registrarme";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = global::main.Properties.Resources.cerrar1;
            this.btncerrar.Location = new System.Drawing.Point(596, 6);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(55, 53);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(659, 378);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.btninvitado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Market";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btninvitado;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}

