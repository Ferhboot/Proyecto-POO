namespace main
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.txtreporte = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtreporte
            // 
            this.txtreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreporte.Location = new System.Drawing.Point(12, 163);
            this.txtreporte.Multiline = true;
            this.txtreporte.Name = "txtreporte";
            this.txtreporte.Size = new System.Drawing.Size(289, 165);
            this.txtreporte.TabIndex = 2;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.Green;
            this.btnenviar.FlatAppearance.BorderSize = 0;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnenviar.Location = new System.Drawing.Point(167, 334);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(89, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Green;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlimpiar.Location = new System.Drawing.Point(44, 334);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(106, 23);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Restablecer";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::main.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(88, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Describa el Inconveniente Sucedido";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(313, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txtreporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reporte";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar reporte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtreporte;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}