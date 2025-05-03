using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WindowsAppDevelopment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //Btn.Content = "Submit";
            Btn1Grid.Background = new SolidColorBrush(Colors.Aqua);
            Btn1_OnClick(null, null);
        }

        /*private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            var data = OutputText.Text;
            try
            {
                var val =Int32.Parse(data);
                OutputText.Text = ""+(val+1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            var userControl1 = new UserControl1();
            View.Content = userControl1;
            changeColor(Btn2Grid);
            changeColor(Btn1Grid, true);
        }

        private void changeColor(Grid grid, bool isSelected = false)
        {
            var selection = new SolidColorBrush(Colors.Aqua);
            var gray = new SolidColorBrush(Colors.Gray);
            grid.Background = isSelected ? selection : gray;
        }
        
        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            var userControl2 = new UserControl2();
            View.Content = userControl2;
            changeColor(Btn1Grid);
            changeColor(Btn2Grid, true);
        }
        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
        private void Btn5_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItemExit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}