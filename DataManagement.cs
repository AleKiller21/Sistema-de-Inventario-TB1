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
        public void loadComboBox(T dataTable, string column, ref ComboBox cmb)
        {
            foreach (DataRow row in dataTable)
            {
                cmb.Items.Add(row[column].ToString());
            }
            cmb.SelectedItem = cmb.Items[0];
        }
    }
}
