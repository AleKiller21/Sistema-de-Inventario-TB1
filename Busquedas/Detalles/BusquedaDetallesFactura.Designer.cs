namespace SistemaInventario2.Busquedas.Detalles
{
    partial class BusquedaDetallesFactura
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
            this.detallesFacturaGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.detallesFacturaGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // detallesFacturaGridView1
            // 
            this.detallesFacturaGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detallesFacturaGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesFacturaGridView1.Location = new System.Drawing.Point(12, 12);
            this.detallesFacturaGridView1.Name = "detallesFacturaGridView1";
            this.detallesFacturaGridView1.ReadOnly = true;
            this.detallesFacturaGridView1.Size = new System.Drawing.Size(637, 257);
            this.detallesFacturaGridView1.TabIndex = 0;
            // 
            // BusquedaDetallesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(661, 325);
            this.Controls.Add(this.detallesFacturaGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BusquedaDetallesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Factura";
            this.Load += new System.EventHandler(this.BusquedaDetallesFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallesFacturaGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detallesFacturaGridView1;
    }
}