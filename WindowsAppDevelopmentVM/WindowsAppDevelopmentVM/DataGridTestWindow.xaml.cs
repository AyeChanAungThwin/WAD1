using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows;
using WindowsAppDevelopmentVM.Utils;

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

            Person prn1 = new Person();
            prn1.Name = "Mg Mg";
            prn1.Age = 30;

            Person prn2 = new Person();
            prn2.Name = "Ma Ma";
            prn2.Age = 45;

            var people = new List<Person>();
            people.Add(prn1);
            people.Add(prn2);

            var dt = DataTableUtils.toDataTable<Person>(people);
            _vm.Dt = dt;

            //DataTableUtils.Add(prn1, _vm.Dt);
            //DataTableUtils.Add(prn2, _vm.Dt);
            
            //DataTableUtils.Add(new Cat("Hello Kitty", "Red"), _vm.Dt);
            /*var dataTable = _vm.Dt;
            var row = dataTable.NewRow();
            row["No"] = 1;
            row["Name"] = prn1.Name;
            row["Age"] = prn2.Age;

            _vm.Dt.Rows.Add(row);*/
        }
        
        public DataGridTestVM getVM()
        {
            return _vm;
        }
    }
}