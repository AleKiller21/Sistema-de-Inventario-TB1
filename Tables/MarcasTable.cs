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
    public partial class MarcasTable : Form
    {
        public MarcasTable()
        {
            InitializeComponent();
        }

        private void mARCASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mARCASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void MarcasTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.MARCAS' table. You can move, or remove it, as needed.
            this.mARCASTableAdapter.Fill(this.dB2DataSet.MARCAS);

        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Ingrese el numero de una marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int numero = Int32.Parse(txtID.Text);
                    Busquedas.BusquedaMarca busqueda = new Busquedas.BusquedaMarca(numero);
                    busqueda.Show();
                }

                catch(Exception)
                {
                    MessageBox.Show("Numero de marca no valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
