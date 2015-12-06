namespace SistemaInventario2
{
    partial class Inventarios
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
            this.tablelist = new System.Windows.Forms.ListBox();
            this.aJUSTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB2DataSet = new SistemaInventario2.DB2DataSet();
            this.aJUSTESTableAdapter = new SistemaInventario2.DB2DataSetTableAdapters.AJUSTESTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aJUSTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablelist
            // 
            this.tablelist.BackColor = System.Drawing.Color.Snow;
            this.tablelist.FormattingEnabled = true;
            this.tablelist.HorizontalScrollbar = true;
            this.tablelist.Location = new System.Drawing.Point(12, 12);
            this.tablelist.Name = "tablelist";
            this.tablelist.Size = new System.Drawing.Size(156, 472);
            this.tablelist.Sorted = true;
            this.tablelist.TabIndex = 0;
            this.tablelist.SelectedIndexChanged += new System.EventHandler(this.tablelist_SelectedIndexChanged);
            // 
            // aJUSTESBindingSource
            // 
            this.aJUSTESBindingSource.DataMember = "AJUSTES";
            this.aJUSTESBindingSource.DataSource = this.dB2DataSetBindingSource;
            // 
            // dB2DataSetBindingSource
            // 
            this.dB2DataSetBindingSource.DataSource = this.dB2DataSet;
            this.dB2DataSetBindingSource.Position = 0;
            // 
            // dB2DataSet
            // 
            this.dB2DataSet.DataSetName = "DB2DataSet";
            this.dB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aJUSTESTableAdapter
            // 
            this.aJUSTESTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(194, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 472);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(953, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tablelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Inventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aJUSTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tablelist;
        private System.Windows.Forms.BindingSource dB2DataSetBindingSource;
        private DB2DataSet dB2DataSet;
        private System.Windows.Forms.BindingSource aJUSTESBindingSource;
        private DB2DataSetTableAdapters.AJUSTESTableAdapter aJUSTESTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}