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
    public partial class Ventas : Form
    {
        int codProducto;
        int numFactura;
        DataManagement<DB2DataSet.PRODUCTOSDataTable> dataProductos;
        QueriesTableAdapter queryAdapter;

        public Ventas()
        {
            dataProductos = new DataManagement<DB2DataSet.PRODUCTOSDataTable>();
            queryAdapter = new QueriesTableAdapter();

            InitializeComponent();
            cargarComboxBox();
            obtenerNumeroFactura();
        }

        private void cargarComboxBox()
        {
            DB2DataSet.PRODUCTOSDataTable productos = new PRODUCTOSTableAdapter().GetData();
            dataProductos.loadComboBox(productos, "NOMBRE", ref cmbProducto);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = (dataProductos.executeSQL("SELECT CODIGO FROM PRODUCTOS WHERE NOMBRE = @pNOMBRE", true, "@pNOMBRE", cmbProducto.SelectedItem.ToString())).ToString();
            codProducto = Int32.Parse(txtCodigoProducto.Text);
        }

        private void btnAgregdarDetalle_Click(object sender, EventArgs e)
        {
            double precio = (Double)dataProductos.executeSQL("SELECT PRECIO FROM PRODUCTOS WHERE CODIGO = @pCODIGO", true, "@pCODIGO", codProducto.ToString());
            try
            {
                txtTotalDetalle.Text = (Double.Parse(txtCantidad.Text) * precio).ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            queryAdapter.SP_DETALLES_FACTURA_CREATE(numFactura, codProducto, Int32.Parse(txtCantidad.Text), ActiveUser.UserID);
            detallesGridView1.DataSource = new SP_DETALLES_FACTURA_READTableAdapter().GetData(numFactura);
        }

        private void obtenerNumeroFactura()
        {
            DB2DataSet.FACTURASDataTable dataFacturas = new FACTURASTableAdapter().GetData();
            numFactura = Int32.Parse(dataFacturas.Rows[dataFacturas.Rows.Count - 1]["NUMERO"].ToString());
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            queryAdapter.SP_FACTURAS_UPDATE(numFactura, 0, ActiveUser.UserID);
            MessageBox.Show("La venta ha sido registrada en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
