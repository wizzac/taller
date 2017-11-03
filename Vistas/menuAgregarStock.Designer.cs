namespace Vistas
{
    partial class menuAgregarStock
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudcantidadagregar = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadagregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 45);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad a agregar";
            // 
            // nudcantidadagregar
            // 
            this.nudcantidadagregar.Location = new System.Drawing.Point(11, 105);
            this.nudcantidadagregar.Name = "nudcantidadagregar";
            this.nudcantidadagregar.Size = new System.Drawing.Size(120, 20);
            this.nudcantidadagregar.TabIndex = 1;
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(34, 172);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarStock.TabIndex = 2;
            this.btnAgregarStock.Text = "Agregar";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            // 
            // menuAgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 261);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.nudcantidadagregar);
            this.Controls.Add(this.lblCantidad);
            this.Name = "menuAgregarStock";
            this.Text = "menuAgregarStock";
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadagregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudcantidadagregar;
        private System.Windows.Forms.Button btnAgregarStock;
    }
}