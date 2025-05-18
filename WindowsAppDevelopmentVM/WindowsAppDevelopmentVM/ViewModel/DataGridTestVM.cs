using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Input;
using WindowsAppDevelopmentVM.Utils;
using WindowsAppDevelopmentVM.View;

namespace WindowsAppDevelopmentVM
{
    public class DataGridTestVM: ViewModelBase
    {
        private DataTable _dt = new DataTable();

        public DataTable Dt
        {
            get => _dt;
            set
            {
                _dt = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Person> _ppl = new ObservableCollection<Person>();

        public ObservableCollection<Person> Ppl
        {
            get => _ppl;
            set
            {
                _ppl = value;
                OnPropertyChanged();
            }
        }
        
        public ICommand AddPersonBtn { get; set; }
        
        public DataGridTestVM()
        {
            AddPersonBtn = new RelayCommand(OnAddingPersonBtn, IsAccessible);
            //populateDataTable();
        }

        private void OnAddingPersonBtn(object obj)
        {
            var win = new AddPersonWindow();
            win.setVM(this);
            win.Show();
        }

        private bool IsAccessible(object obj)
        {
            return true;
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