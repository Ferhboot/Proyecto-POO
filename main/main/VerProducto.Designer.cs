namespace main
{
    partial class VerProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProducto));
            this.lbnombre = new System.Windows.Forms.Label();
            this.txbdescripcion = new System.Windows.Forms.TextBox();
            this.lbvendendor = new System.Windows.Forms.Label();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.btncontactar = new System.Windows.Forms.Button();
            this.btncarrito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbstock = new System.Windows.Forms.Label();
            this.ncant = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbcategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncant)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbnombre.AutoSize = true;
            this.lbnombre.BackColor = System.Drawing.Color.Transparent;
            this.lbnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.Black;
            this.lbnombre.Location = new System.Drawing.Point(24, 15);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(134, 18);
            this.lbnombre.TabIndex = 2;
            this.lbnombre.Text = "NombreProducto";
            // 
            // txbdescripcion
            // 
            this.txbdescripcion.BackColor = System.Drawing.Color.White;
            this.txbdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txbdescripcion.Location = new System.Drawing.Point(27, 46);
            this.txbdescripcion.Multiline = true;
            this.txbdescripcion.Name = "txbdescripcion";
            this.txbdescripcion.ReadOnly = true;
            this.txbdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbdescripcion.Size = new System.Drawing.Size(363, 151);
            this.txbdescripcion.TabIndex = 3;
            this.txbdescripcion.Text = "Descripción";
            // 
            // lbvendendor
            // 
            this.lbvendendor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbvendendor.AutoSize = true;
            this.lbvendendor.BackColor = System.Drawing.Color.Transparent;
            this.lbvendendor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvendendor.ForeColor = System.Drawing.Color.Black;
            this.lbvendendor.Location = new System.Drawing.Point(131, 214);
            this.lbvendendor.Name = "lbvendendor";
            this.lbvendendor.Size = new System.Drawing.Size(94, 17);
            this.lbvendendor.TabIndex = 4;
            this.lbvendendor.Text = "Comerciante";
            this.lbvendendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbimagen
            // 
            this.pbimagen.BackColor = System.Drawing.Color.LightSlateGray;
            this.pbimagen.Location = new System.Drawing.Point(414, 15);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(215, 258);
            this.pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen.TabIndex = 1;
            this.pbimagen.TabStop = false;
            // 
            // btncontactar
            // 
            this.btncontactar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btncontactar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncontactar.FlatAppearance.BorderSize = 0;
            this.btncontactar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontactar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontactar.ForeColor = System.Drawing.Color.White;
            this.btncontactar.Location = new System.Drawing.Point(414, 294);
            this.btncontactar.Name = "btncontactar";
            this.btncontactar.Size = new System.Drawing.Size(215, 31);
            this.btncontactar.TabIndex = 2;
            this.btncontactar.Text = "Contactar al vendedor";
            this.btncontactar.UseVisualStyleBackColor = false;
            // 
            // btncarrito
            // 
            this.btncarrito.BackColor = System.Drawing.Color.Crimson;
            this.btncarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarrito.FlatAppearance.BorderSize = 0;
            this.btncarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarrito.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarrito.ForeColor = System.Drawing.Color.White;
            this.btncarrito.Location = new System.Drawing.Point(197, 296);
            this.btncarrito.Name = "btncarrito";
            this.btncarrito.Size = new System.Drawing.Size(181, 31);
            this.btncarrito.TabIndex = 3;
            this.btncarrito.Text = "Agregar al carrito";
            this.btncarrito.UseVisualStyleBackColor = false;
            this.btncarrito.Click += new System.EventHandler(this.btncarrito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock:";
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstock.Location = new System.Drawing.Point(83, 254);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(17, 20);
            this.lbstock.TabIndex = 5;
            this.lbstock.Text = "0";
            // 
            // ncant
            // 
            this.ncant.ForeColor = System.Drawing.Color.Black;
            this.ncant.Location = new System.Drawing.Point(99, 302);
            this.ncant.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ncant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ncant.Name = "ncant";
            this.ncant.Size = new System.Drawing.Size(68, 23);
            this.ncant.TabIndex = 6;
            this.ncant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ordernar:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comerciante:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoría:";
            // 
            // lbcategoria
            // 
            this.lbcategoria.AutoSize = true;
            this.lbcategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategoria.ForeColor = System.Drawing.Color.IndianRed;
            this.lbcategoria.Location = new System.Drawing.Point(224, 254);
            this.lbcategoria.Name = "lbcategoria";
            this.lbcategoria.Size = new System.Drawing.Size(17, 20);
            this.lbcategoria.TabIndex = 9;
            this.lbcategoria.Text = "0";
            // 
            // VerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 354);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.txbdescripcion);
            this.Controls.Add(this.lbcategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbvendendor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ncant);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncarrito);
            this.Controls.Add(this.btncontactar);
            this.Controls.Add(this.pbimagen);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VerProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txbdescripcion;
        private System.Windows.Forms.Label lbvendendor;
        private System.Windows.Forms.PictureBox pbimagen;
        private System.Windows.Forms.Button btncontactar;
        private System.Windows.Forms.Button btncarrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.NumericUpDown ncant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbcategoria;
    }
}