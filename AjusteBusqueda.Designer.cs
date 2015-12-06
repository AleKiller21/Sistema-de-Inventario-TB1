namespace SistemaInventario2
{
    partial class AjusteBusqueda
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
            this.ajusteGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajusteGridView1
            // 
            this.ajusteGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ajusteGridView1.Location = new System.Drawing.Point(12, 12);
            this.ajusteGridView1.Name = "ajusteGridView1";
            this.ajusteGridView1.Size = new System.Drawing.Size(654, 236);
            this.ajusteGridView1.TabIndex = 0;
            // 
            // AjusteBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(678, 273);
            this.Controls.Add(this.ajusteGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AjusteBusqueda";
            this.Text = "AjusteBusqueda";
            this.Load += new System.EventHandler(this.AjusteBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajusteGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ajusteGridView1;
    }
}