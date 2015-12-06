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
    public partial class BusquedaProducto : Form
    {
        int productoCodigo;

        public BusquedaProducto(int productoCodigo)
        {
            InitializeComponent();
            this.productoCodigo = productoCodigo;
        }

        private void BusquedaProducto_Load(object sender, EventArgs e)
        {
            SP_PRODUCTOS_READTableAdapter adapter = new SP_PRODUCTOS_READTableAdapter();
            productoGridView1.DataSource = adapter.GetData(this.productoCodigo);
        }
    }
}
