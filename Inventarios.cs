using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventario2.DB2DataSetTableAdapters;

namespace SistemaInventario2
{
    public partial class Inventarios : Form
    {
        public Inventarios()
        {
            InitializeComponent();
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.AJUSTES' table. You can move, or remove it, as needed.
            //this.aJUSTESTableAdapter.Fill(this.dB2DataSet.AJUSTES);

            VW_TABLE_NAMESTableAdapter tableNameAdapter = new VW_TABLE_NAMESTableAdapter();
            DB2DataSet.VW_TABLE_NAMESDataTable tableData = tableNameAdapter.GetData();
            List<string> tables = new List<string>();

            foreach (DataRow row in tableData)
            {
                tables.Add(row["NAME"].ToString());
            }

            tablelist.DataSource = tables;
            tabControl1.TabPages[0].Text = tablelist.GetItemText(tablelist.SelectedItem);

            //DataGridView dataView = DGV_Creation(new DataGridView(), 7, 5);
            //dataView.Location = new System.Drawing.Point(6, 6);
            //dataView.Width = 727;
            //dataView.Height = 434;
            //dataView.Visible = true;

            //AGREGAR DATAGRIDVIEW AL TABCONTROL

        }

        private DataGridView DGV_Creation(DataGridView dgv, int columns, int rows)
        {
            for (int i = 1; i <= columns; i++)
            {
                dgv.Columns.Add("col" + i, "column " + i);
            }
            for (int j = 0; j < rows; j++)
            {
                dgv.Rows.Add();
            }
            return dgv;
        }

        private void tablelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
