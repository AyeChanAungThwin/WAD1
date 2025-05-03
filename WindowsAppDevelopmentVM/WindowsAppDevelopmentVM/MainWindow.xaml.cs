namespace WindowsAppDevelopmentVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private MainVM _mainVm;
        public MainWindow()
        {
            InitializeComponent();
            _mainVm = new MainVM();
            DataContext = _mainVm;
        }
    }
}