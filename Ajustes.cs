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
    public partial class Ajustes : Form
    {
        DataManagement<DB2DataSet.PRODUCTOSDataTable> dataProductos;
        QueriesTableAdapter queryAdapter;
        int idAjuste;
        int codProducto;
        int cantidad;

        public Ajustes()
        {
            dataProductos = new DataManagement<DB2DataSet.PRODUCTOSDataTable>();
            queryAdapter = new QueriesTableAdapter();

            InitializeComponent();
            cargarComboxBox();
            obtenerIdAjuste();

            rbEntrada.Checked = true;
        }

        private void cargarComboxBox()
        {
            DB2DataSet.PRODUCTOSDataTable productos = new PRODUCTOSTableAdapter().GetData();
            dataProductos.loadComboBox(productos, "NOMBRE", ref cmbProductos);
        }

        private void obtenerIdAjuste()
        {
            DB2DataSet.AJUSTESDataTable dataAjustes = new AJUSTESTableAdapter().GetData();
            idAjuste = Int32.Parse(dataAjustes.Rows[dataAjustes.Rows.Count - 1]["ID"].ToString());
        }

        private void ingresarDetalleAjuste(string tipoAjuste)
        {
            try
            {
                queryAdapter.SP_DETALLES_AJUSTE_CREATE(idAjuste, codProducto, cantidad, tipoAjuste, ActiveUser.UserID);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            detalleAjustesGridView1.DataSource = new SP_DETALLES_AJUSTE_READTableAdapter().GetData(idAjuste);
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            codProducto = (Int32)dataProductos.executeSQL("SELECT CODIGO FROM PRODUCTOS WHERE NOMBRE = @pNOMBRE", true, "@pNOMBRE", cmbProductos.SelectedItem.ToString());
            //MessageBox.Show(codProducto.ToString());
        }

        private void btnTerminarAjuste_Click(object sender, EventArgs e)
        {
            queryAdapter.SP_AJUSTES_UPDATE(idAjuste, null, ActiveUser.UserID);
            MessageBox.Show("El ajuste ha sido registrado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese un valor numerico en la cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                cantidad = Int32.Parse(txtCantidad.Text);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (rbEntrada.Checked)
            {
                ingresarDetalleAjuste("1");
            }

            else
            {
                ingresarDetalleAjuste("0");
            }
        }
    }
}
