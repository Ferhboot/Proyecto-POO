namespace main
{
    partial class Publicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publicacion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnSERVICIO = new System.Windows.Forms.RadioButton();
            this.rbtnBIEN = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dtvpublicaciones = new System.Windows.Forms.DataGridView();
            this.btnREGRESAR = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblimagen = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtpormayor = new System.Windows.Forms.TextBox();
            this.lblpormayor = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvpublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(40, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lble);
            this.tabPage1.Controls.Add(this.txtpormayor);
            this.tabPage1.Controls.Add(this.lblpormayor);
            this.tabPage1.Controls.Add(this.btnAgregarImagen);
            this.tabPage1.Controls.Add(this.lblimagen);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.lblnombre);
            this.tabPage1.Controls.Add(this.txtdescripcion);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnGUARDAR);
            this.tabPage1.Controls.Add(this.txtcantidad);
            this.tabPage1.Controls.Add(this.lblcantidad);
            this.tabPage1.Controls.Add(this.txtprecio);
            this.tabPage1.Controls.Add(this.lblprecio);
            this.tabPage1.Controls.Add(this.cmbcategoria);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbtnSERVICIO);
            this.tabPage1.Controls.Add(this.rbtnBIEN);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(819, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "DESCRIPCION:";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(36, 405);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(216, 35);
            this.btnGUARDAR.TabIndex = 10;
            this.btnGUARDAR.Text = "GUARDAR";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtcantidad.Location = new System.Drawing.Point(461, 139);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(111, 22);
            this.txtcantidad.TabIndex = 9;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(458, 108);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(73, 16);
            this.lblcantidad.TabIndex = 8;
            this.lblcantidad.Text = "CANTIDAD:";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtprecio.Location = new System.Drawing.Point(296, 139);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(135, 22);
            this.txtprecio.TabIndex = 7;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(293, 108);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(114, 16);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "PRECIO UNITARIO:";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(563, 57);
            this.cmbcategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(215, 25);
            this.cmbcategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CATEGORIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "VIÑETA";
            // 
            // rbtnSERVICIO
            // 
            this.rbtnSERVICIO.AutoSize = true;
            this.rbtnSERVICIO.BackColor = System.Drawing.Color.White;
            this.rbtnSERVICIO.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSERVICIO.Location = new System.Drawing.Point(93, 60);
            this.rbtnSERVICIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnSERVICIO.Name = "rbtnSERVICIO";
            this.rbtnSERVICIO.Size = new System.Drawing.Size(80, 21);
            this.rbtnSERVICIO.TabIndex = 1;
            this.rbtnSERVICIO.Text = "SERVICIO";
            this.rbtnSERVICIO.UseVisualStyleBackColor = false;
            // 
            // rbtnBIEN
            // 
            this.rbtnBIEN.AutoSize = true;
            this.rbtnBIEN.Checked = true;
            this.rbtnBIEN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBIEN.Location = new System.Drawing.Point(36, 60);
            this.rbtnBIEN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnBIEN.Name = "rbtnBIEN";
            this.rbtnBIEN.Size = new System.Drawing.Size(51, 21);
            this.rbtnBIEN.TabIndex = 0;
            this.rbtnBIEN.TabStop = true;
            this.rbtnBIEN.Text = "BIEN";
            this.rbtnBIEN.UseVisualStyleBackColor = true;
            this.rbtnBIEN.CheckedChanged += new System.EventHandler(this.rbtnBIEN_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnELIMINAR);
            this.tabPage2.Controls.Add(this.btnAGREGAR);
            this.tabPage2.Controls.Add(this.dtvpublicaciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(819, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.Location = new System.Drawing.Point(17, 361);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(117, 26);
            this.btnELIMINAR.TabIndex = 2;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.Location = new System.Drawing.Point(17, 328);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(117, 26);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            // 
            // dtvpublicaciones
            // 
            this.dtvpublicaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtvpublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvpublicaciones.Location = new System.Drawing.Point(7, 7);
            this.dtvpublicaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvpublicaciones.Name = "dtvpublicaciones";
            this.dtvpublicaciones.Size = new System.Drawing.Size(804, 302);
            this.dtvpublicaciones.TabIndex = 0;
            // 
            // btnREGRESAR
            // 
            this.btnREGRESAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnREGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnREGRESAR.FlatAppearance.BorderSize = 0;
            this.btnREGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREGRESAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGRESAR.ForeColor = System.Drawing.Color.White;
            this.btnREGRESAR.Location = new System.Drawing.Point(45, 553);
            this.btnREGRESAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnREGRESAR.Name = "btnREGRESAR";
            this.btnREGRESAR.Size = new System.Drawing.Size(818, 37);
            this.btnREGRESAR.TabIndex = 1;
            this.btnREGRESAR.Text = "REGRESAR";
            this.btnREGRESAR.UseVisualStyleBackColor = false;
            this.btnREGRESAR.Click += new System.EventHandler(this.btnREGRESAR_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdescripcion.Location = new System.Drawing.Point(296, 220);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(487, 220);
            this.txtdescripcion.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnombre.Location = new System.Drawing.Point(296, 60);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(215, 22);
            this.txtnombre.TabIndex = 14;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(293, 28);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(151, 16);
            this.lblnombre.TabIndex = 13;
            this.lblnombre.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblimagen
            // 
            this.lblimagen.AutoSize = true;
            this.lblimagen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimagen.Location = new System.Drawing.Point(33, 108);
            this.lblimagen.Name = "lblimagen";
            this.lblimagen.Size = new System.Drawing.Size(57, 16);
            this.lblimagen.TabIndex = 16;
            this.lblimagen.Text = "IMAGEN";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(36, 335);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(216, 35);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "BUSCAR IMAGEN";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtpormayor
            // 
            this.txtpormayor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpormayor.Location = new System.Drawing.Point(601, 140);
            this.txtpormayor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpormayor.Name = "txtpormayor";
            this.txtpormayor.Size = new System.Drawing.Size(183, 22);
            this.txtpormayor.TabIndex = 19;
            // 
            // lblpormayor
            // 
            this.lblpormayor.AutoSize = true;
            this.lblpormayor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpormayor.Location = new System.Drawing.Point(598, 109);
            this.lblpormayor.Name = "lblpormayor";
            this.lblpormayor.Size = new System.Drawing.Size(164, 16);
            this.lblpormayor.TabIndex = 18;
            this.lblpormayor.Text = "CANTIDAD AL POR MAYOR:";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(598, 166);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(98, 17);
            this.lble.TabIndex = 20;
            this.lble.Text = "*solo empresas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registro de publicación";
            // 
            // Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(902, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnREGRESAR);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Publicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicacion";
            this.Load += new System.EventHandler(this.Publicacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvpublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSERVICIO;
        private System.Windows.Forms.RadioButton rbtnBIEN;
        private System.Windows.Forms.DataGridView dtvpublicaciones;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnREGRESAR;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblimagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.TextBox txtpormayor;
        private System.Windows.Forms.Label lblpormayor;
        private System.Windows.Forms.Label label3;
    }
}