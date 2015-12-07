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
    public partial class DetallesAjustesTable : Form
    {
        public DetallesAjustesTable()
        {
            InitializeComponent();
        }

        private void DetallesAjustesTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB2DataSet.VW_DETALLES_AJUSTE' table. You can move, or remove it, as needed.
            this.vW_DETALLES_AJUSTETableAdapter.Fill(this.dB2DataSet.VW_DETALLES_AJUSTE);

        }

        private void txtAjusteId_Click(object sender, EventArgs e)
        {
            txtAjusteId.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtAjusteId.Text == "")
            {
                MessageBox.Show("Porfavor llenar ambas casillas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int idAjuste = Int32.Parse(txtAjusteId.Text);
                    Busquedas.Detalles.BusquedaDetallesAjuste busqueda = new Busquedas.Detalles.BusquedaDetallesAjuste(idAjuste);
                    busqueda.Show();
                }

                catch(Exception)
                {
                    MessageBox.Show("El numero de Detalle o el ID del Ajuste se ingreso de manera incorrecta.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
