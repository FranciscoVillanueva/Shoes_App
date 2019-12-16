namespace ShoesApp
{
    partial class Principal
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
            this.NombreBuscar = new System.Windows.Forms.TextBox();
            this.BuscaPorNombreBoton = new System.Windows.Forms.Button();
            this.BuscaPorIdBoton = new System.Windows.Forms.Button();
            this.IdBuscar = new System.Windows.Forms.TextBox();
            this.EliminaProd = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.NuevoProductoBot = new System.Windows.Forms.Button();
            this.MuestradataGrid = new System.Windows.Forms.DataGridView();
            this.Uno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nueve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Once = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catorce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dieciseis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensajes = new System.Windows.Forms.Label();
            this.NuevaImagen = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Anterior = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImNum = new System.Windows.Forms.Label();
            this.TotIm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MuestradataGrid)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreBuscar
            // 
            this.NombreBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NombreBuscar.Location = new System.Drawing.Point(39, 48);
            this.NombreBuscar.Name = "NombreBuscar";
            this.NombreBuscar.Size = new System.Drawing.Size(365, 26);
            this.NombreBuscar.TabIndex = 0;
            // 
            // BuscaPorNombreBoton
            // 
            this.BuscaPorNombreBoton.Location = new System.Drawing.Point(468, 42);
            this.BuscaPorNombreBoton.Name = "BuscaPorNombreBoton";
            this.BuscaPorNombreBoton.Size = new System.Drawing.Size(175, 38);
            this.BuscaPorNombreBoton.TabIndex = 2;
            this.BuscaPorNombreBoton.Text = "Busca por nombre";
            this.BuscaPorNombreBoton.UseVisualStyleBackColor = true;
            this.BuscaPorNombreBoton.Click += new System.EventHandler(this.buscaPorNombre_Click);
            // 
            // BuscaPorIdBoton
            // 
            this.BuscaPorIdBoton.Location = new System.Drawing.Point(468, 92);
            this.BuscaPorIdBoton.Name = "BuscaPorIdBoton";
            this.BuscaPorIdBoton.Size = new System.Drawing.Size(175, 38);
            this.BuscaPorIdBoton.TabIndex = 4;
            this.BuscaPorIdBoton.Text = "Busca por Id";
            this.BuscaPorIdBoton.UseVisualStyleBackColor = true;
            this.BuscaPorIdBoton.Click += new System.EventHandler(this.BuscaPorIdBoton_Click);
            // 
            // IdBuscar
            // 
            this.IdBuscar.Location = new System.Drawing.Point(39, 98);
            this.IdBuscar.Name = "IdBuscar";
            this.IdBuscar.Size = new System.Drawing.Size(365, 26);
            this.IdBuscar.TabIndex = 3;
            // 
            // EliminaProd
            // 
            this.EliminaProd.Enabled = false;
            this.EliminaProd.Location = new System.Drawing.Point(1178, 50);
            this.EliminaProd.Name = "EliminaProd";
            this.EliminaProd.Size = new System.Drawing.Size(181, 33);
            this.EliminaProd.TabIndex = 5;
            this.EliminaProd.Text = "Eliminar";
            this.EliminaProd.UseVisualStyleBackColor = true;
            this.EliminaProd.Click += new System.EventHandler(this.EliminaProd_Click);
            // 
            // Editar
            // 
            this.Editar.Enabled = false;
            this.Editar.Location = new System.Drawing.Point(956, 50);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(181, 30);
            this.Editar.TabIndex = 6;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // NuevoProductoBot
            // 
            this.NuevoProductoBot.Location = new System.Drawing.Point(736, 48);
            this.NuevoProductoBot.Name = "NuevoProductoBot";
            this.NuevoProductoBot.Size = new System.Drawing.Size(181, 32);
            this.NuevoProductoBot.TabIndex = 7;
            this.NuevoProductoBot.Text = "Nuevo producto";
            this.NuevoProductoBot.UseVisualStyleBackColor = true;
            this.NuevoProductoBot.Click += new System.EventHandler(this.NuevoProducto_Click);
            // 
            // MuestradataGrid
            // 
            this.MuestradataGrid.AllowUserToDeleteRows = false;
            this.MuestradataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MuestradataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MuestradataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uno,
            this.Dos,
            this.Tres,
            this.Cuatro,
            this.Cinco,
            this.Seis,
            this.Siete,
            this.Ocho,
            this.Nueve,
            this.Diez,
            this.Once,
            this.Doce,
            this.Trece,
            this.Catorce,
            this.Quince,
            this.Dieciseis});
            this.MuestradataGrid.Location = new System.Drawing.Point(12, 185);
            this.MuestradataGrid.Name = "MuestradataGrid";
            this.MuestradataGrid.RowTemplate.Height = 28;
            this.MuestradataGrid.Size = new System.Drawing.Size(1840, 107);
            this.MuestradataGrid.TabIndex = 8;
            // 
            // Uno
            // 
            this.Uno.HeaderText = "Id";
            this.Uno.Name = "Uno";
            this.Uno.ReadOnly = true;
            this.Uno.Width = 59;
            // 
            // Dos
            // 
            this.Dos.HeaderText = "IdType";
            this.Dos.Name = "Dos";
            this.Dos.Width = 93;
            // 
            // Tres
            // 
            this.Tres.HeaderText = "IdColor";
            this.Tres.Name = "Tres";
            this.Tres.Width = 96;
            // 
            // Cuatro
            // 
            this.Cuatro.HeaderText = "IdBrand";
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Width = 102;
            // 
            // Cinco
            // 
            this.Cinco.HeaderText = "IdProvider";
            this.Cinco.Name = "Cinco";
            this.Cinco.Width = 116;
            // 
            // Seis
            // 
            this.Seis.HeaderText = "IdCatalog";
            this.Seis.Name = "Seis";
            this.Seis.Width = 114;
            // 
            // Siete
            // 
            this.Siete.HeaderText = "Title";
            this.Siete.Name = "Siete";
            this.Siete.Width = 74;
            // 
            // Ocho
            // 
            this.Ocho.HeaderText = "Nombre";
            this.Ocho.Name = "Ocho";
            this.Ocho.Width = 101;
            // 
            // Nueve
            // 
            this.Nueve.HeaderText = "Description";
            this.Nueve.Name = "Nueve";
            this.Nueve.Width = 125;
            // 
            // Diez
            // 
            this.Diez.HeaderText = "Observations";
            this.Diez.Name = "Diez";
            this.Diez.Width = 138;
            // 
            // Once
            // 
            this.Once.HeaderText = "PriceDistributor";
            this.Once.Name = "Once";
            this.Once.Width = 153;
            // 
            // Doce
            // 
            this.Doce.HeaderText = "PriceClient";
            this.Doce.Name = "Doce";
            this.Doce.Width = 120;
            // 
            // Trece
            // 
            this.Trece.HeaderText = "PriceMember";
            this.Trece.Name = "Trece";
            this.Trece.Width = 138;
            // 
            // Catorce
            // 
            this.Catorce.HeaderText = "IsEnabled";
            this.Catorce.Name = "Catorce";
            this.Catorce.Width = 117;
            // 
            // Quince
            // 
            this.Quince.HeaderText = "Keywords";
            this.Quince.Name = "Quince";
            this.Quince.Width = 113;
            // 
            // Dieciseis
            // 
            this.Dieciseis.HeaderText = "Date Update";
            this.Dieciseis.Name = "Dieciseis";
            this.Dieciseis.Width = 137;
            // 
            // Mensajes
            // 
            this.Mensajes.AutoSize = true;
            this.Mensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensajes.Location = new System.Drawing.Point(161, 151);
            this.Mensajes.Name = "Mensajes";
            this.Mensajes.Size = new System.Drawing.Size(87, 25);
            this.Mensajes.TabIndex = 33;
            this.Mensajes.Text = "Mensaje";
            // 
            // NuevaImagen
            // 
            this.NuevaImagen.Enabled = false;
            this.NuevaImagen.Location = new System.Drawing.Point(1390, 48);
            this.NuevaImagen.Name = "NuevaImagen";
            this.NuevaImagen.Size = new System.Drawing.Size(180, 35);
            this.NuevaImagen.TabIndex = 34;
            this.NuevaImagen.Text = "Agrega una imagen";
            this.NuevaImagen.UseVisualStyleBackColor = true;
            this.NuevaImagen.Click += new System.EventHandler(this.NuevaImagen_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.Foto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(240, 350);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1454, 658);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(3, 3);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(889, 329);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Foto.TabIndex = 0;
            this.Foto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Las imagenes del producto";
            // 
            // Anterior
            // 
            this.Anterior.Enabled = false;
            this.Anterior.Location = new System.Drawing.Point(646, 307);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(160, 37);
            this.Anterior.TabIndex = 38;
            this.Anterior.Text = "<-- Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Enabled = false;
            this.Siguiente.Location = new System.Drawing.Point(883, 307);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(160, 37);
            this.Siguiente.TabIndex = 39;
            this.Siguiente.Text = "Siguiente -->";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Imagen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "de";
            // 
            // ImNum
            // 
            this.ImNum.AutoSize = true;
            this.ImNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImNum.Location = new System.Drawing.Point(95, 389);
            this.ImNum.Name = "ImNum";
            this.ImNum.Size = new System.Drawing.Size(23, 25);
            this.ImNum.TabIndex = 42;
            this.ImNum.Text = "#";
            // 
            // TotIm
            // 
            this.TotIm.AutoSize = true;
            this.TotIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotIm.Location = new System.Drawing.Point(164, 389);
            this.TotIm.Name = "TotIm";
            this.TotIm.Size = new System.Drawing.Size(23, 25);
            this.TotIm.TabIndex = 43;
            this.TotIm.Text = "#";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.TotIm);
            this.Controls.Add(this.ImNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.NuevaImagen);
            this.Controls.Add(this.Mensajes);
            this.Controls.Add(this.MuestradataGrid);
            this.Controls.Add(this.NuevoProductoBot);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.EliminaProd);
            this.Controls.Add(this.BuscaPorIdBoton);
            this.Controls.Add(this.IdBuscar);
            this.Controls.Add(this.BuscaPorNombreBoton);
            this.Controls.Add(this.NombreBuscar);
            this.Name = "Principal";
            this.Text = "Busca un producto y edita";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MuestradataGrid)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBuscar;
        private System.Windows.Forms.Button BuscaPorNombreBoton;
        private System.Windows.Forms.Button BuscaPorIdBoton;
        private System.Windows.Forms.TextBox IdBuscar;
        private System.Windows.Forms.Button EliminaProd;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button NuevoProductoBot;
        private System.Windows.Forms.DataGridView MuestradataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nueve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Once;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catorce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quince;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dieciseis;
        private System.Windows.Forms.Label Mensajes;
        private System.Windows.Forms.Button NuevaImagen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ImNum;
        private System.Windows.Forms.Label TotIm;
    }
}

