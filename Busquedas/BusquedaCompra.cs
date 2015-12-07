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

namespace SistemaInventario2.Busquedas
{
    public partial class BusquedaCompra : Form
    {
        int id;

        public BusquedaCompra(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void BusquedaCompra_Load(object sender, EventArgs e)
        {
            comprasGridView1.DataSource = new SP_COMPRAS_READTableAdapter().GetData(this.id);
        }
    }
}
