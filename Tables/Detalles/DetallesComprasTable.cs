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
    public partial class DetallesComprasTable : Form
    {
        public DetallesComprasTable()
        {
            InitializeComponent();
        }

        private void dETALLES_COMPRABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dETALLES_COMPRABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void dETALLES_COMPRABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dETALLES_COMPRABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void DetallesComprasTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.DETALLES_COMPRA' table. You can move, or remove it, as needed.
            this.dETALLES_COMPRATableAdapter.Fill(this.dB2DataSet.DETALLES_COMPRA);

        }

        private void txtAjusteId_Click(object sender, EventArgs e)
        {
            txtAjusteId.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtAjusteId.Text == "")
            {
                MessageBox.Show("Ingrese el ID de una de las compras realizadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int id = Int32.Parse(txtAjusteId.Text);
                    Busquedas.Detalles.BusquedaDetallesCompras busqueda = new Busquedas.Detalles.BusquedaDetallesCompras(id);
                    busqueda.Show();
                }

                catch(Exception)
                {
                    MessageBox.Show("El ID ingresado no es valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
