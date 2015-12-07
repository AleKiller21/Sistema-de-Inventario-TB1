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
    public partial class BusquedaDetallesAjuste : Form
    {
        int id;

        public BusquedaDetallesAjuste(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void BusquedaDetallesAjuste_Load(object sender, EventArgs e)
        {
            detallesAjusteGridView1.DataSource = new SP_DETALLES_AJUSTE_READTableAdapter().GetData(this.id);
        }
    }
}
