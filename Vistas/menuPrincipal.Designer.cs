namespace Vistas
{
    partial class menuPrincipal
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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnDeudores = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.dgvAlert = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(52, 42);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(158, 43);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(52, 106);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(158, 43);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(52, 170);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(158, 43);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(52, 234);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(158, 43);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnDeudores
            // 
            this.btnDeudores.Location = new System.Drawing.Point(52, 298);
            this.btnDeudores.Name = "btnDeudores";
            this.btnDeudores.Size = new System.Drawing.Size(158, 43);
            this.btnDeudores.TabIndex = 4;
            this.btnDeudores.Text = "Deudores";
            this.btnDeudores.UseVisualStyleBackColor = true;
            // 
            // btnAdm
            // 
            this.btnAdm.Location = new System.Drawing.Point(52, 362);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(158, 43);
            this.btnAdm.TabIndex = 5;
            this.btnAdm.Text = "Administrar Usuarios";
            this.btnAdm.UseVisualStyleBackColor = true;
            // 
            // dgvAlert
            // 
            this.dgvAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlert.Location = new System.Drawing.Point(335, 42);
            this.dgvAlert.Name = "dgvAlert";
            this.dgvAlert.Size = new System.Drawing.Size(505, 277);
            this.dgvAlert.TabIndex = 6;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(465, 362);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(244, 43);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(522, 26);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(131, 13);
            this.lblAlert.TabIndex = 8;
            this.lblAlert.Text = "ALERTA STOCK MINIMO";
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 449);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvAlert);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnDeudores);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnStock);
            this.Name = "menuPrincipal";
            this.Text = "menuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnDeudores;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.DataGridView dgvAlert;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblAlert;
    }
}