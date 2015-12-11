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
using System.Data.SqlClient;
using IBM.Data.DB2;

namespace SistemaInventario2
{
    public partial class NuevaVenta : Form
    {
        public string nombreCliente;
        public int idCliente;
        public int numFactura;
        DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable> data;//Ignorar el tipo de T
        QueriesTableAdapter queryAdapter;

        public NuevaVenta()
        {
            data = new DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable>();
            queryAdapter = new QueriesTableAdapter();

            InitializeComponent();
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text != "")
            {
                try
                {
                    numFactura = txtFactura.Text == "" ? -1 : Int32.Parse(txtFactura.Text);

                    if(numFactura != -1)
                    {
                        if(validarNumFactura() == 1)
                        {
                            MessageBox.Show("El numero de factura ya existe. Ingresar otro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtFactura.Text = "";
                            return;
                        }
                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                nombreCliente = txtCliente.Text;
                if (validarCliente() == 1)
                {
                    idCliente = (Int32)data.executeSQL("SELECT ID FROM CLIENTES WHERE NOMBRE = @pNOMBRE", true, "@pNOMBRE", txtCliente.Text);
                    
                    if(numFactura == -1)
                    {
                        queryAdapter.SP_FACTURAS_CREATE(null, idCliente, ActiveUser.UserID);
                    }

                    else
                    {
                        queryAdapter.SP_FACTURAS_CREATE(numFactura, idCliente, ActiveUser.UserID);
                    }

                    MessageBox.Show("Se ha creado una nueva factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    queryAdapter.Dispose();

                    Ventas ventas = new Ventas();
                    ventas.Show();
                    this.Close();
                }

                else
                {
                    NuevoCliente nCliente = new NuevoCliente(this);
                    nCliente.Show();
                }
            }

            else
            {
                MessageBox.Show("Ingrese el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int validarCliente()
        {
            return (Int32)data.executeSQL("SELECT COUNT(NOMBRE) FROM CLIENTES WHERE NOMBRE = @pNOMBRE", true, "@pNOMBRE", txtCliente.Text);
        }

        private int validarNumFactura()
        {
            return (Int32)data.executeSQL("SELECT COUNT(NUMERO) FROM FACTURAS WHERE NUMERO = @pNUMERO", true, "@pNUMERO", numFactura.ToString());
        }
    }
}
