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
    public partial class FacturasTable : Form
    {
        public FacturasTable()
        {
            InitializeComponent();
        }

        private void fACTURASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fACTURASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void FacturasTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.FACTURAS' table. You can move, or remove it, as needed.
            this.fACTURASTableAdapter.Fill(this.dB2DataSet.FACTURAS);

        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Ingrese el numero registrado de una compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int id = Int32.Parse(txtID.Text);
                    Busquedas.BusquedaFactura busqueda = new Busquedas.BusquedaFactura(id);
                    busqueda.Show();

                }

                catch(Exception)
                {
                    MessageBox.Show("Numero de compra no valido!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
