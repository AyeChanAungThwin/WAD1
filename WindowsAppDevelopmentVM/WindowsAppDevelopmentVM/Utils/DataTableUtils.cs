using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;

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

        private static bool _isAddColumn = false;

        public static void resetDataTable()
        {
            _isAddColumn = false;
        }
        
        public static void Add<T>(T obj, DataTable dataTable) {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (!_isAddColumn)
            {
                _isAddColumn = true;
                foreach (var prop in props)
                {
                    dataTable.Columns.Add(prop.Name);
                }
            }
            
            var values = new object[props.Length];
            for (var i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(obj, null);
            }

            dataTable.Rows.Add(values);
        }

        public static DataTable toDataTable<T>(List<T> items)
        {
            var dataTable = createDataTable();

            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        
        public static DataTable toDataTable<T>(ObservableCollection<T> items)
        {
            var dataTable = createDataTable();

            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}