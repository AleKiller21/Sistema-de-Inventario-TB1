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
    public partial class BusquedaProveedor : Form
    {
        int codigo;

        public BusquedaProveedor(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void BusquedaProveedor_Load(object sender, EventArgs e)
        {
            proveedorGridView1.DataSource = new SP_PROVEEDORES_READTableAdapter().GetData(this.codigo);
        }
    }
}
