using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using WindowsAppDevelopmentVM.Utils;

namespace WindowsAppDevelopmentVM.View
{
    public partial class AddPersonWindow : Window
    {
        private DataGridTestVM _vm;
        
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        public void setVM(DataGridTestVM vm)
        {
            _vm = vm;
        }

        public DataGridTestVM getVM()
        {
            return _vm;
        }
        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+"); //A-Z, A-Za-z
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var name= Name.Text;
            var age = Age.Text;

            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(age))
            {
                MessageBox.Show("Please enter data to both fields");
                return;
            }

            var prn = new Person();
            prn.Name = name;
            prn.Age = Int32.Parse(age);
            
            _vm.Ppl.Add(prn);
            _vm.Dt = DataTableUtils.toDataTable(_vm.Ppl);
            
            Close();
        }
    }
}