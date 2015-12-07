using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario2
{
    public partial class AjustesTable : Form
    {
        public AjustesTable()
        {
            InitializeComponent();
        }

        private void aJUSTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aJUSTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB2DataSet);

        }

        private void AjustesTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.AJUSTES' table. You can move, or remove it, as needed.
            this.aJUSTESTableAdapter.Fill(this.dB2DataSet.AJUSTES);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Ingrese un id valido.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int id = Int32.Parse(txtID.Text);
                    AjusteBusqueda ajuste = new AjusteBusqueda(id);
                    ajuste.Show();
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Ingrese un id valido.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
