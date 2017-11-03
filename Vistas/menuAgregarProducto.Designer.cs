namespace Vistas
{
    partial class menuAgregarProducto
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(246, 62);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 153);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 185);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 89);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 217);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(12, 249);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(71, 13);
            this.lblStockMinimo.TabIndex = 7;
            this.lblStockMinimo.Text = "Stock Minimo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 121);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(133, 22);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(223, 20);
            this.tbCodigo.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(133, 57);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(223, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(133, 86);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(223, 20);
            this.tbDescripcion.TabIndex = 11;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(133, 150);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(223, 20);
            this.tbMarca.TabIndex = 13;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(133, 182);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(223, 20);
            this.tbPrecio.TabIndex = 14;
            this.tbPrecio.Text = "$";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(133, 214);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(120, 20);
            this.nudStock.TabIndex = 15;
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(133, 246);
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(120, 20);
            this.nudStockMin.TabIndex = 16;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(132, 118);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(224, 21);
            this.cbCategoria.TabIndex = 17;
            // 
            // menuAgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 424);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.nudStockMin);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "menuAgregarStock";
            this.Text = "menuAgregarStock";
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}