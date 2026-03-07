using Microsoft.UI.Xaml;

namespace GERM.Views
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RootFrame.Navigate(typeof(MainPage));
        }
    }
}
