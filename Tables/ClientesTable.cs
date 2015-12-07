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
    public partial class ClientesTable : Form
    {
        public ClientesTable()
        {
            InitializeComponent();
        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void ClientesTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.CLIENTES' table. You can move, or remove it, as needed.
            this.cLIENTESTableAdapter.Fill(this.dB2DataSet.CLIENTES);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Ingrese el id del cliente a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int id = Int32.Parse(txtID.Text);
                    Busquedas.BusquedaCliente busqueda = new Busquedas.BusquedaCliente(id);
                    busqueda.Show();
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("ID no valido.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
