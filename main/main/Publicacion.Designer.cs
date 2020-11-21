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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publicacion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lble = new System.Windows.Forms.Label();
            this.txtpormayor = new System.Windows.Forms.TextBox();
            this.lblpormayor = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblimagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dtvpublicaciones = new System.Windows.Forms.DataGridView();
            this.btnREGRESAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprec = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtsto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvpublicaciones)).BeginInit();
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
            this.tabPage1.Text = "Agregar nuevo";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdescripcion.Location = new System.Drawing.Point(296, 220);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(487, 220);
            this.txtdescripcion.TabIndex = 12;
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
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cbcat);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtsto);
            this.tabPage2.Controls.Add(this.txtdesc);
            this.tabPage2.Controls.Add(this.txtprec);
            this.tabPage2.Controls.Add(this.txtnom);
            this.tabPage2.Controls.Add(this.btneliminar);
            this.tabPage2.Controls.Add(this.btnupdate);
            this.tabPage2.Controls.Add(this.dtvpublicaciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(819, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mis productos";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.YellowGreen;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(675, 397);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(117, 54);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar este producto";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(675, 328);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 54);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Actualizar información";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // dtvpublicaciones
            // 
            this.dtvpublicaciones.AllowUserToAddRows = false;
            this.dtvpublicaciones.AllowUserToDeleteRows = false;
            this.dtvpublicaciones.AllowUserToResizeRows = false;
            this.dtvpublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvpublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvpublicaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvpublicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvpublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvpublicaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvpublicaciones.EnableHeadersVisualStyles = false;
            this.dtvpublicaciones.Location = new System.Drawing.Point(9, 32);
            this.dtvpublicaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvpublicaciones.MultiSelect = false;
            this.dtvpublicaciones.Name = "dtvpublicaciones";
            this.dtvpublicaciones.ReadOnly = true;
            this.dtvpublicaciones.RowHeadersVisible = false;
            this.dtvpublicaciones.RowTemplate.Height = 35;
            this.dtvpublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvpublicaciones.Size = new System.Drawing.Size(804, 286);
            this.dtvpublicaciones.TabIndex = 0;
            this.dtvpublicaciones.DoubleClick += new System.EventHandler(this.dtvpublicaciones_DoubleClick);
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
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(449, 325);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(192, 111);
            this.txtdesc.TabIndex = 3;
            // 
            // txtprec
            // 
            this.txtprec.Location = new System.Drawing.Point(124, 385);
            this.txtprec.Name = "txtprec";
            this.txtprec.Size = new System.Drawing.Size(176, 22);
            this.txtprec.TabIndex = 4;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(124, 325);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(176, 22);
            this.txtnom.TabIndex = 6;
            // 
            // txtsto
            // 
            this.txtsto.Location = new System.Drawing.Point(124, 414);
            this.txtsto.Name = "txtsto";
            this.txtsto.Size = new System.Drawing.Size(176, 22);
            this.txtsto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio            $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre";
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(124, 354);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(176, 25);
            this.cbcat.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Doble clic para editar un producto";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvpublicaciones)).EndInit();
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
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnupdate;
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
        private System.Windows.Forms.TextBox txtprec;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsto;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label10;
    }
}