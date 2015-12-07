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
    public partial class BusquedaMarca : Form
    {
        int numero;

        public BusquedaMarca(int numero)
        {
            InitializeComponent();
            this.numero = numero;
        }

        private void BusquedaMarca_Load(object sender, EventArgs e)
        {
            marcaGridView1.DataSource = new SP_MARCAS_READTableAdapter().GetData(numero);
        }
    }
}
