using System.Collections.Generic;
using System.Data;
using WindowsAppDevelopmentVM.Utils;

namespace WindowsAppDevelopmentVM
{
    public class DataGridTestVM: ViewModelBase
    {
        private DataTable _dt;

        public DataTable Dt
        {
            get => _dt;
            set
            {
                _dt = value;
                OnPropertyChanged();
            }
        }
        
        public DataGridTestVM()
        {
            populateDataTable();
        }

        private void populateDataTable()
        {
            var list = new List<string>();
            list.Add("No");
            list.Add("Name");
            list.Add("Age");
            
            var dataTable = DataTableUtils.createDataTable();
            dataTable = DataTableUtils.createColumns(dataTable, list);

            Dt = dataTable;
        }
    }
}