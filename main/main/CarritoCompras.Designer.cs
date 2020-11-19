namespace main
{
    partial class CarritoCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.NumericUpDown();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lbproducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvcarrito = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // cant
            // 
            this.cant.Enabled = false;
            this.cant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.Location = new System.Drawing.Point(124, 120);
            this.cant.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(58, 23);
            this.cant.TabIndex = 2;
            this.cant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Teal;
            this.btnactualizar.Enabled = false;
            this.btnactualizar.FlatAppearance.BorderSize = 0;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Location = new System.Drawing.Point(221, 112);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(157, 37);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "Actualizar cantidad";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Brown;
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(396, 112);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(200, 37);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar producto o servicio";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // lbproducto
            // 
            this.lbproducto.AutoSize = true;
            this.lbproducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducto.Location = new System.Drawing.Point(43, 79);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(0, 17);
            this.lbproducto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carrito de compras";
            // 
            // btnpedido
            // 
            this.btnpedido.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnpedido.FlatAppearance.BorderSize = 0;
            this.btnpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpedido.ForeColor = System.Drawing.Color.White;
            this.btnpedido.Location = new System.Drawing.Point(627, 463);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(121, 37);
            this.btnpedido.TabIndex = 7;
            this.btnpedido.Text = "Finalizar pedido";
            this.btnpedido.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total a pagar:";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbtotal.Location = new System.Drawing.Point(675, 419);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(54, 18);
            this.lbtotal.TabIndex = 9;
            this.lbtotal.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de compra:";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(166, 421);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(45, 17);
            this.lbfecha.TabIndex = 11;
            this.lbfecha.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Haga doble clic en un producto o servicio para verlo o ejecutar alguna acción";
            // 
            // dgvcarrito
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvcarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcarrito.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvcarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvcarrito.ColumnHeadersHeight = 42;
            this.dgvcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcarrito.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvcarrito.EnableHeadersVisualStyles = false;
            this.dgvcarrito.Location = new System.Drawing.Point(46, 197);
            this.dgvcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcarrito.Name = "dgvcarrito";
            this.dgvcarrito.ReadOnly = true;
            this.dgvcarrito.RowHeadersVisible = false;
            this.dgvcarrito.RowTemplate.Height = 42;
            this.dgvcarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcarrito.Size = new System.Drawing.Size(702, 200);
            this.dgvcarrito.TabIndex = 13;
            this.dgvcarrito.DoubleClick += new System.EventHandler(this.dgvcarrito_DoubleClick);
            // 
            // CarritoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 523);
            this.Controls.Add(this.dgvcarrito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnpedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbproducto);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CarritoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito de compras";
            ((System.ComponentModel.ISupportInitialize)(this.cant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cant;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lbproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvcarrito;
    }
}