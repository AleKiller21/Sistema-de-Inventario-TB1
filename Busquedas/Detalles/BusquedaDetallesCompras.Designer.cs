namespace SistemaInventario2.Busquedas.Detalles
{
    partial class BusquedaDetallesCompras
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
            this.detallesCompraGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // detallesCompraGridView1
            // 
            this.detallesCompraGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detallesCompraGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesCompraGridView1.Location = new System.Drawing.Point(12, 12);
            this.detallesCompraGridView1.Name = "detallesCompraGridView1";
            this.detallesCompraGridView1.ReadOnly = true;
            this.detallesCompraGridView1.Size = new System.Drawing.Size(695, 237);
            this.detallesCompraGridView1.TabIndex = 0;
            // 
            // BusquedaDetallesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(719, 309);
            this.Controls.Add(this.detallesCompraGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BusquedaDetallesCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Compra";
            this.Load += new System.EventHandler(this.BusquedaDetallesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detallesCompraGridView1;
    }
}