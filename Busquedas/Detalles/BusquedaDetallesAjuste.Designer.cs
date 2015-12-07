namespace SistemaInventario2.Busquedas.Detalles
{
    partial class BusquedaDetallesAjuste
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
            this.detallesAjusteGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.detallesAjusteGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // detallesAjusteGridView1
            // 
            this.detallesAjusteGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detallesAjusteGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesAjusteGridView1.Location = new System.Drawing.Point(12, 12);
            this.detallesAjusteGridView1.Name = "detallesAjusteGridView1";
            this.detallesAjusteGridView1.ReadOnly = true;
            this.detallesAjusteGridView1.Size = new System.Drawing.Size(727, 253);
            this.detallesAjusteGridView1.TabIndex = 0;
            // 
            // BusquedaDetallesAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(751, 406);
            this.Controls.Add(this.detallesAjusteGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BusquedaDetallesAjuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Ajuste";
            this.Load += new System.EventHandler(this.BusquedaDetallesAjuste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallesAjusteGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detallesAjusteGridView1;
    }
}