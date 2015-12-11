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
    public partial class NuevoAjuste : Form
    {
        int idAjuste;
        DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable> data;//Ignorar el tipo de T

        public NuevoAjuste()
        {
            InitializeComponent();
            data = new DataManagement<DB2DataSet.VW_PROVEEDORES1DataTable>();
        }

        private void btnCrearAjuste_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter queryAdapter = new QueriesTableAdapter();

            if (txtIdAjuste.Text == "")
            {
                queryAdapter.SP_AJUSTE_CREATE(null, null, ActiveUser.UserID);
                MessageBox.Show("Se ha creado un nuevo Ajuste.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ajustes ajuste = new Ajustes();
                ajuste.Show();
                this.Close();
                return;
            }

            try
            {
                idAjuste = Int32.Parse(txtIdAjuste.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if(validarIdAjuste() == 1)
            {
                MessageBox.Show("El ID ingresado ya existe. Ingrese uno nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                queryAdapter.SP_AJUSTE_CREATE(idAjuste, null, ActiveUser.UserID);
                MessageBox.Show("Se ha creado un nuevo Ajuste.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ajustes ajuste = new Ajustes();
                ajuste.Show();
                this.Close();
                
            }
        }

        private int validarIdAjuste()
        {
            return (Int32)data.executeSQL("SELECT COUNT(ID) FROM AJUSTES WHERE ID = @pID", true, "@pID", idAjuste.ToString());
        }
    }
}
