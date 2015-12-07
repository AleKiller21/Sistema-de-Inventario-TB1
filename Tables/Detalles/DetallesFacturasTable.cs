using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario2.Tables.Detalles
{
    public partial class DetallesFacturasTable : Form
    {
        public DetallesFacturasTable()
        {
            InitializeComponent();
        }

        private void dETALLES_FACTURABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dETALLES_FACTURABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void DetallesFacturasTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.DETALLES_FACTURA' table. You can move, or remove it, as needed.
            this.dETALLES_FACTURATableAdapter.Fill(this.dB2DataSet.DETALLES_FACTURA);

        }

        private void txtFacturaNumero_Click(object sender, EventArgs e)
        {
            txtFacturaNumero.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtFacturaNumero.Text == "")
            {
                MessageBox.Show("Ingrese el numero de una de las facturas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int numero = Int32.Parse(txtFacturaNumero.Text);
                    Busquedas.Detalles.BusquedaDetallesFactura busqueda = new Busquedas.Detalles.BusquedaDetallesFactura(numero);
                    busqueda.Show();
                }

                catch(Exception)
                {
                    MessageBox.Show("Numero de factura no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
