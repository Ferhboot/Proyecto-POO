namespace main
{
    partial class Mensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensajes));
            this.dgmensajes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnresponder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtodo = new System.Windows.Forms.RadioButton();
            this.rbleido = new System.Windows.Forms.RadioButton();
            this.rbnoleido = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgmensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgmensajes
            // 
            this.dgmensajes.AllowUserToAddRows = false;
            this.dgmensajes.AllowUserToDeleteRows = false;
            this.dgmensajes.AllowUserToOrderColumns = true;
            this.dgmensajes.AllowUserToResizeRows = false;
            this.dgmensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgmensajes.BackgroundColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgmensajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgmensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgmensajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgmensajes.EnableHeadersVisualStyles = false;
            this.dgmensajes.GridColor = System.Drawing.Color.SandyBrown;
            this.dgmensajes.Location = new System.Drawing.Point(12, 136);
            this.dgmensajes.MultiSelect = false;
            this.dgmensajes.Name = "dgmensajes";
            this.dgmensajes.ReadOnly = true;
            this.dgmensajes.RowHeadersVisible = false;
            this.dgmensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmensajes.Size = new System.Drawing.Size(681, 230);
            this.dgmensajes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(199, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haga doble clic en un mensaje para ver su contenido";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Gold;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(576, 14);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(117, 55);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar Mensaje";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnresponder
            // 
            this.btnresponder.BackColor = System.Drawing.Color.Tan;
            this.btnresponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresponder.Location = new System.Drawing.Point(576, 75);
            this.btnresponder.Name = "btnresponder";
            this.btnresponder.Size = new System.Drawing.Size(115, 55);
            this.btnresponder.TabIndex = 3;
            this.btnresponder.Text = "Responder Mensaje";
            this.btnresponder.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Área de Mensajes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::main.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // rbtodo
            // 
            this.rbtodo.AutoSize = true;
            this.rbtodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtodo.Location = new System.Drawing.Point(304, 14);
            this.rbtodo.Name = "rbtodo";
            this.rbtodo.Size = new System.Drawing.Size(149, 20);
            this.rbtodo.TabIndex = 6;
            this.rbtodo.TabStop = true;
            this.rbtodo.Text = "Todos los mensajes";
            this.rbtodo.UseVisualStyleBackColor = true;
            this.rbtodo.CheckedChanged += new System.EventHandler(this.rbtodo_CheckedChanged);
            // 
            // rbleido
            // 
            this.rbleido.AutoSize = true;
            this.rbleido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbleido.Location = new System.Drawing.Point(304, 56);
            this.rbleido.Name = "rbleido";
            this.rbleido.Size = new System.Drawing.Size(67, 20);
            this.rbleido.TabIndex = 7;
            this.rbleido.TabStop = true;
            this.rbleido.Text = "Leídos";
            this.rbleido.UseVisualStyleBackColor = true;
            this.rbleido.CheckedChanged += new System.EventHandler(this.rbleido_CheckedChanged);
            // 
            // rbnoleido
            // 
            this.rbnoleido.AutoSize = true;
            this.rbnoleido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbnoleido.Location = new System.Drawing.Point(304, 98);
            this.rbnoleido.Name = "rbnoleido";
            this.rbnoleido.Size = new System.Drawing.Size(88, 20);
            this.rbnoleido.TabIndex = 9;
            this.rbnoleido.TabStop = true;
            this.rbnoleido.Text = "No Leídos";
            this.rbnoleido.UseVisualStyleBackColor = true;
            this.rbnoleido.CheckedChanged += new System.EventHandler(this.rbnoleido_CheckedChanged);
            // 
            // Mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(703, 396);
            this.Controls.Add(this.rbnoleido);
            this.Controls.Add(this.rbleido);
            this.Controls.Add(this.rbtodo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnresponder);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgmensajes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Mensajes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensajes";
            this.Load += new System.EventHandler(this.Mensajes_Load);
            this.Shown += new System.EventHandler(this.Mensajes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgmensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgmensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnresponder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtodo;
        private System.Windows.Forms.RadioButton rbleido;
        private System.Windows.Forms.RadioButton rbnoleido;
    }
}