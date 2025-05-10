using System;
using System.Threading;
using System.Windows;

namespace WpfLocalizationTest
{
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
            switch (FileUtils.read())
            {
                case WpfLocalizationTest.Language.English:
                    loadLanguage(WpfLocalizationTest.Language.English);
                    break;
                
                case WpfLocalizationTest.Language.Myanmar:
                    loadLanguage(WpfLocalizationTest.Language.Myanmar);
                    break;
            }
        }
        
        private void loadLanguage(Language language)
        {
            // Remove MergedDictionaries
            Application.Current.Resources.MergedDictionaries.Clear();

            // Add your application-wide resources if needed
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri($"pack://application:,,,/WpfLocalizationTest;component/Resources/{language.ToString()}.xaml") });
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}