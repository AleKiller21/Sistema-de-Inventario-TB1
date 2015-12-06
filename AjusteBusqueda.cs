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
    public partial class AjusteBusqueda : Form
    {
        int id;

        public AjusteBusqueda()
        {
            InitializeComponent();
        }

        public AjusteBusqueda(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AjusteBusqueda_Load(object sender, EventArgs e)
        {
            ajusteGridView1.DataSource = new SP_AJUSTE_READTableAdapter().GetData(this.id);
        }
    }
}
