using System.Windows;

namespace WindowsAppDevelopmentVM
{
    public partial class DataGridTestWindow : Window
    {
        private DataGridTestVM _vm;
        public DataGridTestWindow()
        {
            InitializeComponent();
            _vm = new DataGridTestVM();
            DataContext = _vm;

            Person p = new Person();
            p.Name = "Mg Mg";
            p.Age = 30;

            var dataTable = _vm.Dt;
            var row = dataTable.NewRow();
            row["No"] = 1;
            row["Name"] = p.Name;
            row["Age"] = p.Age;

            _vm.Dt.Rows.Add(row);
        }

        public DataGridTestVM getVM()
        {
            return _vm;
        }
    }
}