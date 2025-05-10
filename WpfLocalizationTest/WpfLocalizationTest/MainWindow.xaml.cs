using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace WpfLocalizationTest
{
    public enum Language
    {
        English,
        Myanmar,
        Chinese
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public static void RestartApplication()
        {
            // Get the path of the current executable
            string applicationPath = Assembly.GetEntryAssembly().Location;

            // Start a new instance of the application
            Process.Start(applicationPath);

            // Shutdown the current application
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_OnClickEnglish(object sender, RoutedEventArgs e)
        {
            //loadLanguage(WpfLocalizationTest.Language.English);
            FileUtils.save(WpfLocalizationTest.Language.English);
            RestartApplication();
        }
        
        private void MenuItem_OnClickMyanmar(object sender, RoutedEventArgs e)
        {
            //loadLanguage(WpfLocalizationTest.Language.Myanmar);
            FileUtils.save(WpfLocalizationTest.Language.Myanmar);
            RestartApplication();
        }
    }
}