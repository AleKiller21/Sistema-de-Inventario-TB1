﻿using System;
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
    public partial class BusquedaFactura : Form
    {
        int numero;

        public BusquedaFactura(int numero)
        {
            InitializeComponent();
            this.numero = numero;
        }

        private void BusquedaFactura_Load(object sender, EventArgs e)
        {
            facturaGridView1.DataSource = new SP_FACTURAS_READTableAdapter().GetData(numero);
        }
    }
}
