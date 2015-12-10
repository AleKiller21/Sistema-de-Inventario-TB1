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
    public partial class Compras : Form
    {
        int idCompra;
        int codProducto;
        int cantidad;


        public Compras()
        {
            InitializeComponent();
            DB2DataSet.COMPRASDataTable data = new COMPRASTableAdapter().GetData();
            idCompra = Int32.Parse(data.Rows[data.Rows.Count-1]["ID"].ToString());
            cargarComboxBox();
        }

        private void btnAgregdarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                DB2DataSet.SP_PRODUCTOS_READDataTable producto = new SP_PRODUCTOS_READTableAdapter().GetData(Int32.Parse(txtCodigoProducto.Text));
                QueriesTableAdapter queryAdapter = new QueriesTableAdapter();
                cantidad = Int32.Parse(txtCantidad.Text);

                txtTotalDetalle.Text = (cantidad * Int32.Parse(producto.Rows[0]["PRECIO"].ToString())).ToString();
                queryAdapter.SP_DETALLES_COMPRA_CREATE(idCompra, codProducto, cantidad, ActiveUser.UserID);
                detallesGridView1.DataSource = new SP_DETALLES_COMPRA_READTableAdapter().GetData(idCompra);
            }

            catch(Exception)
            {
                MessageBox.Show("El valor de cantidad ingresado no es valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarComboxBox()
        {
            DB2DataSet.PRODUCTOSDataTable productos = new PRODUCTOSTableAdapter().GetData();
            new DataManagement<DB2DataSet.PRODUCTOSDataTable>().loadComboBox(productos, "NOMBRE", ref cmbProducto);
        }

        private void obtenerProductoCodigo()
        {
            DB2DataSet.SP_GET_PRODUCTOS_CODIGODataTable table = new SP_GET_PRODUCTOS_CODIGOTableAdapter().GetData(cmbProducto.SelectedItem.ToString());
            txtCodigoProducto.Text = table.Rows[0]["CODIGO"].ToString();
            codProducto = Int32.Parse(txtCodigoProducto.Text);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerProductoCodigo();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter queriesAdapter = new QueriesTableAdapter();
            queriesAdapter.SP_COMPRAS_UPDATE(idCompra, null, ActiveUser.UserID);
            MessageBox.Show("Su compra ha sido registrada en la base de datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
