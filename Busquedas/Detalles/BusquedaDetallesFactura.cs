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

namespace SistemaInventario2.Busquedas.Detalles
{
    public partial class BusquedaDetallesFactura : Form
    {
        int numero;

        public BusquedaDetallesFactura(int numero)
        {
            InitializeComponent();
            this.numero = numero;
        }

        private void BusquedaDetallesFactura_Load(object sender, EventArgs e)
        {
            detallesFacturaGridView1.DataSource = new SP_DETALLES_FACTURA_READTableAdapter().GetData(numero);
        }
    }
}
