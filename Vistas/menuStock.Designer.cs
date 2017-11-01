namespace Vistas
{
    partial class menuStock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImprimirStock = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(311, 44);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(527, 265);
            this.dgvStock.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImprimirStock
            // 
            this.btnImprimirStock.Location = new System.Drawing.Point(777, 4);
            this.btnImprimirStock.Name = "btnImprimirStock";
            this.btnImprimirStock.Size = new System.Drawing.Size(61, 40);
            this.btnImprimirStock.TabIndex = 2;
            this.btnImprimirStock.Text = "Imprimir";
            this.btnImprimirStock.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(497, 327);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 43);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(683, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 43);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(555, 18);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Items.AddRange(new object[] {
            "Todo",
            "Filtros",
            "Aceites"});
            this.cbCategorias.Location = new System.Drawing.Point(75, 44);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(179, 21);
            this.cbCategorias.TabIndex = 8;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 47);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(57, 13);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Categorias";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(85, 154);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(152, 44);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 119);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 14;
            // 
            // menuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 409);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnImprimirStock);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvStock);
            this.Name = "menuStock";
            this.Text = "menuStock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImprimirStock;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBox2;
    }
}