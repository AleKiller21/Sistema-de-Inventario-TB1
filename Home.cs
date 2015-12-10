using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario2
{
    public partial class Home : Form
    {
        Form1 temp;
        public Home(Form1 temp)
        {
            InitializeComponent();
            this.temp = temp;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Usuario: " + ActiveUser.UserID + "; Password: " + ActiveUser.Password);
            ProductosTable pTable = new ProductosTable();
            pTable.Show();
        }

        private void ajustesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjustesTable ajusteTable = new AjustesTable();
            ajusteTable.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.ClientesTable clienteTable = new Tables.ClientesTable();
            clienteTable.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.ComprasTable compraTable = new Tables.ComprasTable();
            compraTable.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.FacturasTable facturaTable = new Tables.FacturasTable();
            facturaTable.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.MarcasTable marcaTable = new Tables.MarcasTable();
            marcaTable.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.ProveedoresTable proveedorTable = new Tables.ProveedoresTable();
            proveedorTable.Show();
        }

        private void detallesDeAjustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.Detalles.DetallesAjustesTable detalleAjusteTable = new Tables.Detalles.DetallesAjustesTable();
            detalleAjusteTable.Show();
        }

        private void detallesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.Detalles.DetallesComprasTable detalleCompraTable = new Tables.Detalles.DetallesComprasTable();
            detalleCompraTable.Show();
        }

        private void detallesDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.Detalles.DetallesFacturasTable detalleFacturaTable = new Tables.Detalles.DetallesFacturasTable();
            detalleFacturaTable.Show();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCompra nCompra = new NuevaCompra();
            nCompra.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            temp.Close();
        }
    }
}
