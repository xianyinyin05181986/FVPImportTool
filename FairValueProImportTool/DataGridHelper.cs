using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FairValueProImportTool
{
    public static class DataGridHelper
    {
        public static string GetCellValueFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
        {
            DataGridViewCell cellCollectionCastFirst = CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText);
            if (cellCollectionCastFirst != null && cellCollectionCastFirst.Value != null)
            {
                return cellCollectionCastFirst.Value.ToString();
            }
            else
                return String.Empty;
        }
    }
}
