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
    public partial class BusquedaCliente : Form
    {
        int id;

        public BusquedaCliente(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            clienteGridView1.DataSource = new SP_CLIENTES_READTableAdapter().GetData(this.id);
        }
    }
}
