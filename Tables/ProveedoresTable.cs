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

namespace SistemaInventario2.Tables
{
    public partial class ProveedoresTable : Form
    {
        public ProveedoresTable()
        {
            InitializeComponent();
        }

        private void ProveedoresTable_Load(object sender, EventArgs e)
        {
            proveedoresGridView1.DataSource = new VW_PROVEEDORESTableAdapter().GetData();
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de uno de los proveedores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int codigo = Int32.Parse(txtCodigo.Text);
                    Busquedas.BusquedaProveedor busqueda = new Busquedas.BusquedaProveedor(codigo);
                    busqueda.Show();

                }

                catch(Exception)
                {
                    MessageBox.Show("Codigo no valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
