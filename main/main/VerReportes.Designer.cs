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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerReportes));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtodo = new System.Windows.Forms.RadioButton();
            this.rbnoleido = new System.Windows.Forms.RadioButton();
            this.rbleido = new System.Windows.Forms.RadioButton();
            this.btnresponder = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Reportes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // rbtodo
            // 
            this.rbtodo.AutoSize = true;
            this.rbtodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtodo.Location = new System.Drawing.Point(365, 285);
            this.rbtodo.Name = "rbtodo";
            this.rbtodo.Size = new System.Drawing.Size(144, 21);
            this.rbtodo.TabIndex = 2;
            this.rbtodo.TabStop = true;
            this.rbtodo.Text = "Todos los Reportes";
            this.rbtodo.UseVisualStyleBackColor = true;
            // 
            // rbnoleido
            // 
            this.rbnoleido.AutoSize = true;
            this.rbnoleido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnoleido.Location = new System.Drawing.Point(365, 322);
            this.rbnoleido.Name = "rbnoleido";
            this.rbnoleido.Size = new System.Drawing.Size(86, 21);
            this.rbnoleido.TabIndex = 3;
            this.rbnoleido.TabStop = true;
            this.rbnoleido.Text = "No leídos";
            this.rbnoleido.UseVisualStyleBackColor = true;
            // 
            // rbleido
            // 
            this.rbleido.AutoSize = true;
            this.rbleido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbleido.Location = new System.Drawing.Point(365, 357);
            this.rbleido.Name = "rbleido";
            this.rbleido.Size = new System.Drawing.Size(66, 21);
            this.rbleido.TabIndex = 4;
            this.rbleido.TabStop = true;
            this.rbleido.Text = "Leídos";
            this.rbleido.UseVisualStyleBackColor = true;
            // 
            // btnresponder
            // 
            this.btnresponder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnresponder.FlatAppearance.BorderSize = 0;
            this.btnresponder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresponder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresponder.Location = new System.Drawing.Point(63, 312);
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
            this.btneliminar.Location = new System.Drawing.Point(184, 312);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(83, 40);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // VerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(524, 384);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnresponder);
            this.Controls.Add(this.rbleido);
            this.Controls.Add(this.rbnoleido);
            this.Controls.Add(this.rbtodo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "VerReportes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtodo;
        private System.Windows.Forms.RadioButton rbnoleido;
        private System.Windows.Forms.RadioButton rbleido;
        private System.Windows.Forms.Button btnresponder;
        private System.Windows.Forms.Button btneliminar;
    }
}