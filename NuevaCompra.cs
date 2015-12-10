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
    public partial class NuevaCompra : Form
    {
        public NuevaCompra()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
                try
                {
                    int idCompra = txtIdCompra.Text == "" ? -1 : Int32.Parse(txtIdCompra.Text);

                    if (validarIdCompra())
                    {
                        MessageBox.Show("Los valores ingresados son validos.", "Exito", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        QueriesTableAdapter adapter = new QueriesTableAdapter();
                        
                        if(idCompra == -1)
                        {
                            adapter.SP_COMPRAS_CREATE(null, obtenerIdProveedor(cmbProveedor.SelectedItem.ToString()), null, ActiveUser.UserID);
                            Compras cp = new Compras();
                            cp.Show();
                            this.Close();
                        }

                        else
                        {
                            adapter.SP_COMPRAS_CREATE(idCompra, obtenerIdProveedor(cmbProveedor.SelectedItem.ToString()), null, ActiveUser.UserID);
                            int x = obtenerIdProveedor(cmbProveedor.SelectedItem.ToString());
                            Compras cp = new Compras();
                            cp.Show();
                            this.Close();
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Los valores ingresados no son validos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }            
        }

        private bool validarIdCompra()
        {
            bool idValido = true;

            if (txtIdCompra.Text == "")
                return idValido;

            DB2DataSet.VW_COMPRASDataTable comprasDataTable = new VW_COMPRASTableAdapter().GetData();

            foreach (DataRow row in comprasDataTable)
            {
                if (row["ID"].ToString() == txtIdCompra.Text)
                {
                    MessageBox.Show("El ID de la compra ingresado ya existe.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtIdCompra.Text = "";
                    idValido = false;
                    break;
                }
            }

            return idValido;
        }

        private void NuevaCompra_Load(object sender, EventArgs e)
        {
            //VW_PROVEEDORES1 devuelve el nombre de todos los proveedores sin que estos se repitan.
            DB2DataSet.VW_PROVEEDORES1DataTable proveedorDataTable = new VW_PROVEEDORES1TableAdapter().GetData();
            new DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable>().loadComboBox(proveedorDataTable,
                "NOMBRE", ref cmbProveedor);
        }

        private int obtenerIdProveedor(string nombreProveedor)
        {
            DB2DataSet.SP_OBTENER_CODIGO_PROVEEDORDataTable dataTable = new SP_OBTENER_CODIGO_PROVEEDORTableAdapter().GetData(nombreProveedor);            
            return Int32.Parse(dataTable.Rows[0]["CODIGO"].ToString());
        }
    }
}
