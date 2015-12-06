namespace SistemaInventario2
{
    partial class AjustesTable
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
            this.components = new System.ComponentModel.Container();
            this.dB2DataSet = new SistemaInventario2.DB2DataSet();
            this.aJUSTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aJUSTESTableAdapter = new SistemaInventario2.DB2DataSetTableAdapters.AJUSTESTableAdapter();
            this.tableAdapterManager = new SistemaInventario2.DB2DataSetTableAdapters.TableAdapterManager();
            this.aJUSTESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJUSTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJUSTESDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB2DataSet
            // 
            this.dB2DataSet.DataSetName = "DB2DataSet";
            this.dB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aJUSTESBindingSource
            // 
            this.aJUSTESBindingSource.DataMember = "AJUSTES";
            this.aJUSTESBindingSource.DataSource = this.dB2DataSet;
            // 
            // aJUSTESTableAdapter
            // 
            this.aJUSTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AJUSTESTableAdapter = this.aJUSTESTableAdapter;
            this.tableAdapterManager.AUDITORIAS_INVENTARIOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.COMPRASTableAdapter = null;
            this.tableAdapterManager.DETALLES_AJUSTETableAdapter = null;
            this.tableAdapterManager.DETALLES_COMPRATableAdapter = null;
            this.tableAdapterManager.DETALLES_FACTURATableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.MARCASTableAdapter = null;
            this.tableAdapterManager.PRIVILEGIOSTableAdapter = null;
            this.tableAdapterManager.PRODUCTOSTableAdapter = null;
            this.tableAdapterManager.PROVEEDOR_TELEFONOSTableAdapter = null;
            this.tableAdapterManager.PROVEEDORESTableAdapter = null;
            this.tableAdapterManager.ROLES_PRIVILEGIOSTableAdapter = null;
            this.tableAdapterManager.ROLESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaInventario2.DB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_ROLESTableAdapter = null;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // aJUSTESDataGridView
            // 
            this.aJUSTESDataGridView.AutoGenerateColumns = false;
            this.aJUSTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aJUSTESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.aJUSTESDataGridView.DataSource = this.aJUSTESBindingSource;
            this.aJUSTESDataGridView.Location = new System.Drawing.Point(12, 12);
            this.aJUSTESDataGridView.Name = "aJUSTESDataGridView";
            this.aJUSTESDataGridView.Size = new System.Drawing.Size(745, 270);
            this.aJUSTESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FECHA";
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TOTAL_PRODUCTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "TOTAL_PRODUCTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FECHA_CREACION";
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHA_CREACION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FECHA_ACTUALIZACION";
            this.dataGridViewTextBoxColumn5.HeaderText = "FECHA_ACTUALIZACION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "USUARIO_CREACION";
            this.dataGridViewTextBoxColumn6.HeaderText = "USUARIO_CREACION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "USUARIO_ACTUALIZACION";
            this.dataGridViewTextBoxColumn7.HeaderText = "USUARIO_ACTUALIZACION";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(214, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 42);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(6, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            // 
            // AjustesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(781, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aJUSTESDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AjustesTable";
            this.Text = "AjustesTable";
            this.Load += new System.EventHandler(this.AjustesTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJUSTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJUSTESDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DB2DataSet dB2DataSet;
        private System.Windows.Forms.BindingSource aJUSTESBindingSource;
        private DB2DataSetTableAdapters.AJUSTESTableAdapter aJUSTESTableAdapter;
        private DB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView aJUSTESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}