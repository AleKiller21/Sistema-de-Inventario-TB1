using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventario2.DB2DataSetTableAdapters;

namespace SistemaInventario2
{
    public partial class ProductosTable : Form
    {
        public ProductosTable()
        {
            InitializeComponent();
        }

        private void ProductosTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.VW_PRODUCTOS' table. You can move, or remove it, as needed.
            this.vW_PRODUCTOSTableAdapter.Fill(this.dB2DataSet.VW_PRODUCTOS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Porfavor ingrese el codigo de un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int codigo = Int32.Parse(txtCodigo.Text);
                    BusquedaProducto busqueda = new BusquedaProducto(codigo);
                    busqueda.Show();
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Ingrese un id valido.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
        }
    }
}
