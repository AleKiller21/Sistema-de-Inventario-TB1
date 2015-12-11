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
    public partial class NuevoCliente : Form
    {
        NuevaVenta dialog;
        int idCliente;

        public NuevoCliente(NuevaVenta dialog)
        {
            this.dialog = dialog;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter queryAdapter = new QueriesTableAdapter();
            
            try
            {
                idCliente = txtIdCliente.Text == "" ? -1 : Int32.Parse(txtIdCliente.Text);

                if(idCliente == -1)
                {
                    queryAdapter.SP_CLIENTES_CREATE(null, dialog.nombreCliente, ActiveUser.UserID);
                }

                else
                {
                    if(validarIdCliente() == 1)
                    {
                        MessageBox.Show("El id ingresado ya existe. Ingresar uno nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtIdCliente.Text = "";
                        return;
                    }

                    else
                    {
                        queryAdapter.SP_CLIENTES_CREATE(idCliente, dialog.nombreCliente, ActiveUser.UserID);
                    }
                }

                DB2DataSet.CLIENTESDataTable dataTable = new CLIENTESTableAdapter().GetData();
                idCliente = Int32.Parse(dataTable.Rows[dataTable.Rows.Count - 1]["ID"].ToString());

                if(dialog.numFactura == -1)
                {
                    queryAdapter.SP_FACTURAS_CREATE(null, idCliente, ActiveUser.UserID);
                }

                else
                {
                    queryAdapter.SP_FACTURAS_CREATE(dialog.numFactura, idCliente, ActiveUser.UserID);
                }

                MessageBox.Show("Se ha creado una nueva factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ventas ventas = new Ventas();
                ventas.Show();
                this.dialog.Close();
                this.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            queryAdapter.Dispose();
        }

        private int validarIdCliente()
        {
            DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable> data = new DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable>();
            return (Int32)data.executeSQL("SELECT COUNT(ID) FROM CLIENTES WHERE ID = @pID", true, "@pID", txtIdCliente.Text);
        }
    }
}
