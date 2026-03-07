using GERM.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace GERM.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = App.GetService<MainViewModel>();
        }
    }
}
