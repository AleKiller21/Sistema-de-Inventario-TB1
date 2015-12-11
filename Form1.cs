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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            USUARIOSTableAdapter usersAdapter = new USUARIOSTableAdapter();
            DB2DataSet.USUARIOSDataTable userDataTable = usersAdapter.GetData();
            bool sesion = false;

            foreach(DataRow row in userDataTable)
            {
                if(row["NOMBRE"].ToString() == txtUser.Text && row["CLAVE"].ToString() == txtClave.Text)
                {
                    MessageBox.Show("Bienvenido. " + txtUser.Text, "Usuario encontrado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    sesion = true;
                    ActiveUser.UserID = row["NOMBRE"].ToString();
                    ActiveUser.Password = row["CLAVE"].ToString();
                    break;
                }
            }

            if(sesion)
            {
                Home home = new Home(this);
                home.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Tal usuario no existe en la base de datos. Contacte al administrador del sistema.", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
