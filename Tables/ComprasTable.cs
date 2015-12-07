using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario2.Tables
{
    public partial class ComprasTable : Form
    {
        public ComprasTable()
        {
            InitializeComponent();
        }

        private void cOMPRASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPRASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void ComprasTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.COMPRAS' table. You can move, or remove it, as needed.
            this.cOMPRASTableAdapter.Fill(this.dB2DataSet.COMPRAS);

        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Ingrese el id de una alguna compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int id = Int32.Parse(txtID.Text);
                    Busquedas.BusquedaCompra busqueda = new Busquedas.BusquedaCompra(id);
                    busqueda.Show();
                }

                catch(Exception)
                {
                    MessageBox.Show("ID no valido!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
