namespace SistemaInventario2
{
    partial class Ajustes
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
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSalida = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detalleAjustesGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTerminarAjuste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleAjustesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntrada.ForeColor = System.Drawing.Color.Snow;
            this.rbEntrada.Location = new System.Drawing.Point(6, 53);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(75, 19);
            this.rbEntrada.TabIndex = 0;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // rbSalida
            // 
            this.rbSalida.AutoSize = true;
            this.rbSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSalida.ForeColor = System.Drawing.Color.Snow;
            this.rbSalida.Location = new System.Drawing.Point(6, 107);
            this.rbSalida.Name = "rbSalida";
            this.rbSalida.Size = new System.Drawing.Size(66, 19);
            this.rbSalida.TabIndex = 1;
            this.rbSalida.TabStop = true;
            this.rbSalida.Text = "Salida";
            this.rbSalida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(7, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(81, 164);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 23);
            this.cmbProductos.TabIndex = 3;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(404, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(494, 53);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(146, 21);
            this.txtCantidad.TabIndex = 5;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnAgregarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(407, 140);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(233, 47);
            this.btnAgregarDetalle.TabIndex = 6;
            this.btnAgregarDetalle.Text = "Agregar a Ajuste";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProductos);
            this.groupBox1.Controls.Add(this.btnAgregarDetalle);
            this.groupBox1.Controls.Add(this.rbEntrada);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.rbSalida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 231);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Ajuste";
            // 
            // detalleAjustesGridView1
            // 
            this.detalleAjustesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleAjustesGridView1.Location = new System.Drawing.Point(12, 269);
            this.detalleAjustesGridView1.Name = "detalleAjustesGridView1";
            this.detalleAjustesGridView1.Size = new System.Drawing.Size(661, 174);
            this.detalleAjustesGridView1.TabIndex = 8;
            // 
            // btnTerminarAjuste
            // 
            this.btnTerminarAjuste.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTerminarAjuste.FlatAppearance.BorderSize = 2;
            this.btnTerminarAjuste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnTerminarAjuste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnTerminarAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarAjuste.ForeColor = System.Drawing.Color.Snow;
            this.btnTerminarAjuste.Location = new System.Drawing.Point(196, 450);
            this.btnTerminarAjuste.Name = "btnTerminarAjuste";
            this.btnTerminarAjuste.Size = new System.Drawing.Size(273, 58);
            this.btnTerminarAjuste.TabIndex = 7;
            this.btnTerminarAjuste.Text = "Finalizar Ajuste";
            this.btnTerminarAjuste.UseVisualStyleBackColor = false;
            this.btnTerminarAjuste.Click += new System.EventHandler(this.btnTerminarAjuste_Click);
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(685, 520);
            this.Controls.Add(this.btnTerminarAjuste);
            this.Controls.Add(this.detalleAjustesGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Ajustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleAjustesGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.RadioButton rbSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView detalleAjustesGridView1;
        private System.Windows.Forms.Button btnTerminarAjuste;
    }
}