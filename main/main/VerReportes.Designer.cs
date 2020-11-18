namespace main
{
    partial class VerReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerReportes));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgreportes = new System.Windows.Forms.DataGridView();
            this.rbtodo = new System.Windows.Forms.RadioButton();
            this.rbnoleido = new System.Windows.Forms.RadioButton();
            this.rbleido = new System.Windows.Forms.RadioButton();
            this.btnresponder = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgreportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Categoría";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Productos Registrados";
            this.dataGridViewTextBoxColumn3.HeaderText = "Productos Registrados";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Reportes";
            // 
            // dgreportes
            // 
            this.dgreportes.AllowUserToAddRows = false;
            this.dgreportes.AllowUserToDeleteRows = false;
            this.dgreportes.AllowUserToResizeRows = false;
            this.dgreportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgreportes.EnableHeadersVisualStyles = false;
            this.dgreportes.Location = new System.Drawing.Point(16, 46);
            this.dgreportes.Name = "dgreportes";
            this.dgreportes.ReadOnly = true;
            this.dgreportes.RowHeadersVisible = false;
            this.dgreportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgreportes.Size = new System.Drawing.Size(709, 210);
            this.dgreportes.TabIndex = 1;
            this.dgreportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgreportes_CellClick);
            this.dgreportes.DoubleClick += new System.EventHandler(this.dgreportes_DoubleClick);
            // 
            // rbtodo
            // 
            this.rbtodo.AutoSize = true;
            this.rbtodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtodo.Location = new System.Drawing.Point(500, 351);
            this.rbtodo.Name = "rbtodo";
            this.rbtodo.Size = new System.Drawing.Size(144, 21);
            this.rbtodo.TabIndex = 2;
            this.rbtodo.TabStop = true;
            this.rbtodo.Text = "Todos los Reportes";
            this.rbtodo.UseVisualStyleBackColor = true;
            this.rbtodo.CheckedChanged += new System.EventHandler(this.rbtodo_CheckedChanged);
            // 
            // rbnoleido
            // 
            this.rbnoleido.AutoSize = true;
            this.rbnoleido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnoleido.Location = new System.Drawing.Point(500, 277);
            this.rbnoleido.Name = "rbnoleido";
            this.rbnoleido.Size = new System.Drawing.Size(86, 21);
            this.rbnoleido.TabIndex = 3;
            this.rbnoleido.TabStop = true;
            this.rbnoleido.Text = "No leídos";
            this.rbnoleido.UseVisualStyleBackColor = true;
            this.rbnoleido.CheckedChanged += new System.EventHandler(this.rbnoleido_CheckedChanged);
            // 
            // rbleido
            // 
            this.rbleido.AutoSize = true;
            this.rbleido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbleido.Location = new System.Drawing.Point(500, 312);
            this.rbleido.Name = "rbleido";
            this.rbleido.Size = new System.Drawing.Size(66, 21);
            this.rbleido.TabIndex = 4;
            this.rbleido.TabStop = true;
            this.rbleido.Text = "Leídos";
            this.rbleido.UseVisualStyleBackColor = true;
            this.rbleido.CheckedChanged += new System.EventHandler(this.rbleido_CheckedChanged);
            // 
            // btnresponder
            // 
            this.btnresponder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnresponder.FlatAppearance.BorderSize = 0;
            this.btnresponder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresponder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresponder.Location = new System.Drawing.Point(124, 312);
            this.btnresponder.Name = "btnresponder";
            this.btnresponder.Size = new System.Drawing.Size(84, 40);
            this.btnresponder.TabIndex = 5;
            this.btnresponder.Text = "Responder";
            this.btnresponder.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LimeGreen;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(290, 312);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(83, 40);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Haga doble clic en un reporte para verlo o ejecutar alguna acción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // VerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(747, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnresponder);
            this.Controls.Add(this.rbleido);
            this.Controls.Add(this.rbnoleido);
            this.Controls.Add(this.rbtodo);
            this.Controls.Add(this.dgreportes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "VerReportes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Reportes";
            this.Load += new System.EventHandler(this.VerReportes_Load);
            this.Shown += new System.EventHandler(this.VerReportes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgreportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgreportes;
        private System.Windows.Forms.RadioButton rbtodo;
        private System.Windows.Forms.RadioButton rbnoleido;
        private System.Windows.Forms.RadioButton rbleido;
        private System.Windows.Forms.Button btnresponder;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}