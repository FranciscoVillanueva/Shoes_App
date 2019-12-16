namespace ShoesApp
{
    partial class AgregaImagen
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.AgImagen = new System.Windows.Forms.Button();
            this.SelecImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.Mensaje = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Picture);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 691);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(3, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(811, 451);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // AgImagen
            // 
            this.AgImagen.Location = new System.Drawing.Point(950, 29);
            this.AgImagen.Name = "AgImagen";
            this.AgImagen.Size = new System.Drawing.Size(179, 40);
            this.AgImagen.TabIndex = 34;
            this.AgImagen.Text = "Agrega Imagen";
            this.AgImagen.UseVisualStyleBackColor = true;
            this.AgImagen.Click += new System.EventHandler(this.AgImagen_Click);
            // 
            // SelecImagen
            // 
            this.SelecImagen.Location = new System.Drawing.Point(105, 29);
            this.SelecImagen.Name = "SelecImagen";
            this.SelecImagen.Size = new System.Drawing.Size(179, 40);
            this.SelecImagen.TabIndex = 35;
            this.SelecImagen.Text = "Selecciona Imagen";
            this.SelecImagen.UseVisualStyleBackColor = true;
            this.SelecImagen.Click += new System.EventHandler(this.SelecImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(963, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Descripción";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(968, 313);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(773, 26);
            this.Descripcion.TabIndex = 37;
            this.Descripcion.Click += new System.EventHandler(this.Descripcion_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje.Location = new System.Drawing.Point(963, 140);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(87, 25);
            this.Mensaje.TabIndex = 38;
            this.Mensaje.Text = "Mensaje";
            // 
            // AgregaImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 1050);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelecImagen);
            this.Controls.Add(this.AgImagen);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AgregaImagen";
            this.Text = "Agrega Imagen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button AgImagen;
        private System.Windows.Forms.Button SelecImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label Mensaje;
    }
}