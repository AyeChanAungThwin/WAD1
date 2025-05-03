using System.Collections.Generic;
using System.Data;

namespace WindowsAppDevelopmentVM.Utils
{
    public class DataTableUtils
    {
        public static DataTable createDataTable()
        {
            return new DataTable();
        }

        public static DataTable createColumns(DataTable dataTable, List<string> columeNames)
        {
            foreach (var col in columeNames)
            {
                dataTable.Columns.Add(new DataColumn(col));
            }

            return dataTable;
        }
    }
}