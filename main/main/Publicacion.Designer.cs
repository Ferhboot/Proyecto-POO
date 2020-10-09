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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtcantidad_al_por_mayor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprecio_unitario = new System.Windows.Forms.TextBox();
            this.lbxdescripcion = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvpublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnGUARDAR);
            this.tabPage1.Controls.Add(this.txtcantidad_al_por_mayor);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtprecio_unitario);
            this.tabPage1.Controls.Add(this.lbxdescripcion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbcategoria);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbtnSERVICIO);
            this.tabPage1.Controls.Add(this.rbtnBIEN);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "DESCRIPCION";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.Location = new System.Drawing.Point(31, 299);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(185, 30);
            this.btnGUARDAR.TabIndex = 10;
            this.btnGUARDAR.Text = "GUARDAR";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            // 
            // txtcantidad_al_por_mayor
            // 
            this.txtcantidad_al_por_mayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtcantidad_al_por_mayor.Location = new System.Drawing.Point(31, 252);
            this.txtcantidad_al_por_mayor.Name = "txtcantidad_al_por_mayor";
            this.txtcantidad_al_por_mayor.Size = new System.Drawing.Size(185, 20);
            this.txtcantidad_al_por_mayor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CANTIDAD AL POR MAYOR";
            // 
            // txtprecio_unitario
            // 
            this.txtprecio_unitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtprecio_unitario.Location = new System.Drawing.Point(31, 190);
            this.txtprecio_unitario.Name = "txtprecio_unitario";
            this.txtprecio_unitario.Size = new System.Drawing.Size(185, 20);
            this.txtprecio_unitario.TabIndex = 7;
            // 
            // lbxdescripcion
            // 
            this.lbxdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxdescripcion.FormattingEnabled = true;
            this.lbxdescripcion.Location = new System.Drawing.Point(269, 52);
            this.lbxdescripcion.Name = "lbxdescripcion";
            this.lbxdescripcion.Size = new System.Drawing.Size(389, 277);
            this.lbxdescripcion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRECIO UNITARIO";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(31, 130);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(185, 21);
            this.cmbcategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CATEGORIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "VIÑETA";
            // 
            // rbtnSERVICIO
            // 
            this.rbtnSERVICIO.AutoSize = true;
            this.rbtnSERVICIO.BackColor = System.Drawing.Color.White;
            this.rbtnSERVICIO.Location = new System.Drawing.Point(31, 75);
            this.rbtnSERVICIO.Name = "rbtnSERVICIO";
            this.rbtnSERVICIO.Size = new System.Drawing.Size(75, 17);
            this.rbtnSERVICIO.TabIndex = 1;
            this.rbtnSERVICIO.TabStop = true;
            this.rbtnSERVICIO.Text = "SERVICIO";
            this.rbtnSERVICIO.UseVisualStyleBackColor = false;
            // 
            // rbtnBIEN
            // 
            this.rbtnBIEN.AutoSize = true;
            this.rbtnBIEN.Location = new System.Drawing.Point(31, 52);
            this.rbtnBIEN.Name = "rbtnBIEN";
            this.rbtnBIEN.Size = new System.Drawing.Size(50, 17);
            this.rbtnBIEN.TabIndex = 0;
            this.rbtnBIEN.TabStop = true;
            this.rbtnBIEN.Text = "BIEN";
            this.rbtnBIEN.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnELIMINAR);
            this.tabPage2.Controls.Add(this.btnAGREGAR);
            this.tabPage2.Controls.Add(this.dtvpublicaciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.Location = new System.Drawing.Point(15, 313);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(100, 23);
            this.btnELIMINAR.TabIndex = 2;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.Location = new System.Drawing.Point(15, 284);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(100, 23);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            // 
            // dtvpublicaciones
            // 
            this.dtvpublicaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtvpublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvpublicaciones.Location = new System.Drawing.Point(6, 6);
            this.dtvpublicaciones.Name = "dtvpublicaciones";
            this.dtvpublicaciones.Size = new System.Drawing.Size(689, 262);
            this.dtvpublicaciones.TabIndex = 0;
            // 
            // btnREGRESAR
            // 
            this.btnREGRESAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnREGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGRESAR.Location = new System.Drawing.Point(24, 401);
            this.btnREGRESAR.Name = "btnREGRESAR";
            this.btnREGRESAR.Size = new System.Drawing.Size(701, 32);
            this.btnREGRESAR.TabIndex = 1;
            this.btnREGRESAR.Text = "REGRESAR";
            this.btnREGRESAR.UseVisualStyleBackColor = false;
            // 
            // Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 449);
            this.Controls.Add(this.btnREGRESAR);
            this.Controls.Add(this.tabControl1);
            this.Name = "Publicacion";
            this.Text = "Publicacion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvpublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtcantidad_al_por_mayor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprecio_unitario;
        private System.Windows.Forms.ListBox lbxdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSERVICIO;
        private System.Windows.Forms.RadioButton rbtnBIEN;
        private System.Windows.Forms.DataGridView dtvpublicaciones;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnREGRESAR;
    }
}