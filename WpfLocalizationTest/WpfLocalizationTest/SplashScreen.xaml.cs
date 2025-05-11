using System;
using System.Threading;
using System.Threading.Tasks;
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

            Task.Run(() =>
            {
                for (var i = 2; i >= 0; i--)
                {
                    Thread.Sleep(1000);
                    Dispatcher.Invoke(() =>
                    {
                        ShowText.Text = i.ToString();
                    });
                }

                Dispatcher.Invoke(() =>
                {
                    new MainWindow().Show();
                    Close();
                });
            });
        }
        
        private void loadLanguage(Language language)
        {
            // Remove MergedDictionaries
            Application.Current.Resources.MergedDictionaries.Clear();

            // Add your application-wide resources if needed
            addToResources(new Uri($"pack://application:,,,/Resources/{language.ToString()}.xaml"));
            
            loadStyle();
        }

        public void addToResources(Uri uri)
        {
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = uri });
        }

        private void loadStyle()
        {
            addToResources(new Uri($"pack://application:,,,/Styles/Style.xaml"));
        }

        /*private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }*/
    }
}