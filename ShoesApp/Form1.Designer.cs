namespace ShoesApp
{
    partial class Form1
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
            this.button4 = new System.Windows.Forms.Button();
            this.NuevoProductoBot = new System.Windows.Forms.Button();
            this.Dieciseis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catorce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Once = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nueve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuestradataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MuestradataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreBuscar
            // 
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
            this.EliminaProd.Location = new System.Drawing.Point(736, 209);
            this.EliminaProd.Name = "EliminaProd";
            this.EliminaProd.Size = new System.Drawing.Size(181, 33);
            this.EliminaProd.TabIndex = 5;
            this.EliminaProd.Text = "Eliminar";
            this.EliminaProd.UseVisualStyleBackColor = true;
            this.EliminaProd.Click += new System.EventHandler(this.EliminaProd_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(736, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // NuevoProductoBot
            // 
            this.NuevoProductoBot.Location = new System.Drawing.Point(736, 48);
            this.NuevoProductoBot.Name = "NuevoProductoBot";
            this.NuevoProductoBot.Size = new System.Drawing.Size(181, 32);
            this.NuevoProductoBot.TabIndex = 7;
            this.NuevoProductoBot.Text = "Nuevo";
            this.NuevoProductoBot.UseVisualStyleBackColor = true;
            this.NuevoProductoBot.Click += new System.EventHandler(this.NuevoProducto_Click);
            // 
            // Dieciseis
            // 
            this.Dieciseis.HeaderText = "Date Update";
            this.Dieciseis.Name = "Dieciseis";
            this.Dieciseis.Width = 137;
            // 
            // Quince
            // 
            this.Quince.HeaderText = "Keywords";
            this.Quince.Name = "Quince";
            this.Quince.Width = 113;
            // 
            // Catorce
            // 
            this.Catorce.HeaderText = "IsEnabled";
            this.Catorce.Name = "Catorce";
            this.Catorce.Width = 117;
            // 
            // Trece
            // 
            this.Trece.HeaderText = "PriceMember";
            this.Trece.Name = "Trece";
            this.Trece.Width = 138;
            // 
            // Doce
            // 
            this.Doce.HeaderText = "PriceClient";
            this.Doce.Name = "Doce";
            this.Doce.Width = 120;
            // 
            // Once
            // 
            this.Once.HeaderText = "PriceDistributor";
            this.Once.Name = "Once";
            this.Once.Width = 153;
            // 
            // Diez
            // 
            this.Diez.HeaderText = "Observations";
            this.Diez.Name = "Diez";
            this.Diez.Width = 138;
            // 
            // Nueve
            // 
            this.Nueve.HeaderText = "Description";
            this.Nueve.Name = "Nueve";
            this.Nueve.Width = 125;
            // 
            // Ocho
            // 
            this.Ocho.HeaderText = "Nombre";
            this.Ocho.Name = "Ocho";
            this.Ocho.Width = 101;
            // 
            // Siete
            // 
            this.Siete.HeaderText = "Title";
            this.Siete.Name = "Siete";
            this.Siete.Width = 74;
            // 
            // Seis
            // 
            this.Seis.HeaderText = "IdCatalog";
            this.Seis.Name = "Seis";
            this.Seis.Width = 114;
            // 
            // Cinco
            // 
            this.Cinco.HeaderText = "IdProvider";
            this.Cinco.Name = "Cinco";
            this.Cinco.Width = 116;
            // 
            // Cuatro
            // 
            this.Cuatro.HeaderText = "IdBrand";
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Width = 102;
            // 
            // Tres
            // 
            this.Tres.HeaderText = "IdColor";
            this.Tres.Name = "Tres";
            this.Tres.Width = 96;
            // 
            // Dos
            // 
            this.Dos.HeaderText = "IdType";
            this.Dos.Name = "Dos";
            this.Dos.Width = 93;
            // 
            // Uno
            // 
            this.Uno.HeaderText = "Id";
            this.Uno.Name = "Uno";
            this.Uno.Width = 59;
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
            this.MuestradataGrid.Location = new System.Drawing.Point(5, 285);
            this.MuestradataGrid.Name = "MuestradataGrid";
            this.MuestradataGrid.RowTemplate.Height = 28;
            this.MuestradataGrid.Size = new System.Drawing.Size(1136, 107);
            this.MuestradataGrid.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 495);
            this.Controls.Add(this.MuestradataGrid);
            this.Controls.Add(this.NuevoProductoBot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EliminaProd);
            this.Controls.Add(this.BuscaPorIdBoton);
            this.Controls.Add(this.IdBuscar);
            this.Controls.Add(this.BuscaPorNombreBoton);
            this.Controls.Add(this.NombreBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MuestradataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBuscar;
        private System.Windows.Forms.Button BuscaPorNombreBoton;
        private System.Windows.Forms.Button BuscaPorIdBoton;
        private System.Windows.Forms.TextBox IdBuscar;
        private System.Windows.Forms.Button EliminaProd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button NuevoProductoBot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dieciseis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quince;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catorce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Once;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nueve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uno;
        private System.Windows.Forms.DataGridView MuestradataGrid;
    }
}

