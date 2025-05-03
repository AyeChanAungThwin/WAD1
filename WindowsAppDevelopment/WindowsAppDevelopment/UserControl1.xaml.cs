using System;
using System.Windows;
using System.Windows.Controls;

namespace WindowsAppDevelopment
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var data = tb.Text;
            if (!String.IsNullOrEmpty(data.Trim()))
            {
                MessageBox.Show("You typed!: "+data);
                return;
            }

            MessageBox.Show("Nothing to show!");
        }
    }
}