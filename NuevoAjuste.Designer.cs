namespace SistemaInventario2
{
    partial class NuevoAjuste
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAjuste = new System.Windows.Forms.TextBox();
            this.btnCrearAjuste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Ajuste:";
            // 
            // txtIdAjuste
            // 
            this.txtIdAjuste.Location = new System.Drawing.Point(76, 36);
            this.txtIdAjuste.Name = "txtIdAjuste";
            this.txtIdAjuste.Size = new System.Drawing.Size(171, 20);
            this.txtIdAjuste.TabIndex = 1;
            // 
            // btnCrearAjuste
            // 
            this.btnCrearAjuste.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCrearAjuste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCrearAjuste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAjuste.ForeColor = System.Drawing.Color.Snow;
            this.btnCrearAjuste.Location = new System.Drawing.Point(59, 79);
            this.btnCrearAjuste.Name = "btnCrearAjuste";
            this.btnCrearAjuste.Size = new System.Drawing.Size(212, 40);
            this.btnCrearAjuste.TabIndex = 2;
            this.btnCrearAjuste.Text = "Crear Ajuste";
            this.btnCrearAjuste.UseVisualStyleBackColor = false;
            this.btnCrearAjuste.Click += new System.EventHandler(this.btnCrearAjuste_Click);
            // 
            // NuevoAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(330, 131);
            this.Controls.Add(this.btnCrearAjuste);
            this.Controls.Add(this.txtIdAjuste);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NuevoAjuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoAjuste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdAjuste;
        private System.Windows.Forms.Button btnCrearAjuste;
    }
}