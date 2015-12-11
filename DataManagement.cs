using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario2
{
    public class DataManagement<T> where T : System.Collections.IEnumerable
    {
        string connection = "Database=PROYECTO;UserID=Alejandro;Password=ajfz1995;Server=localhost";

        public void loadComboBox(T dataTable, string column, ref ComboBox cmb)
        {
            foreach (DataRow row in dataTable)
            {
                cmb.Items.Add(row[column].ToString());
            }
            cmb.SelectedItem = cmb.Items[0];
        }

        public object executeSQL(string sql, bool parameters, string param, string paramValue)
        {
            using(DB2Connection conn = new DB2Connection(connection))
            {
                DB2Command cmd = new DB2Command(sql, conn);

                if(parameters)
                {
                    cmd.Parameters.Add(param, SqlDbType.VarChar);
                    cmd.Parameters[param].Value = paramValue;
                }

                conn.Open();

                try
                {
                    return cmd.ExecuteScalar();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
