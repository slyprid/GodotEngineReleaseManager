using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERM.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace GERM.ViewModels
{
    public partial class MainViewModel 
        : ObservableObject
    {
        private readonly ILogService _log;

        public ObservableCollection<string> Platforms { get; }
        public ObservableCollection<string> Types { get; }


        [ObservableProperty]
        private string _destinationDirectory = "";

        [ObservableProperty]
        private string _selectedPlatform = "";

        [ObservableProperty]
        private string _selectedType = "";

        [ObservableProperty]
        private string _output = "";

        [ObservableProperty]
        private double _progress;

        [ObservableProperty]
        private bool _isBusy;


        public MainViewModel(ILogService log)
        {
            _log = log;
            
            Platforms = new ObservableCollection<string> 
            {
                "Android",
                "Linux",
                "macOS",
                "Windows",
                "Web Editor",
                "Export Templates"
            };

            Types = new ObservableCollection<string>
            {
                "Standard",
                ".NET"
            };
        }


        [RelayCommand]
        private async Task RunAsync()
        {
            IsBusy = true;
            Progress = 0;

            AppendLine($"Starting export...");
            AppendLine($"Destination: {DestinationDirectory}");
            AppendLine($"Platform: {SelectedPlatform}");
            AppendLine($"Type: {SelectedType}");

            // fake work
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(150);
                Progress = i * 10;
                AppendLine($"Progress: {Progress}%");
            }

            AppendLine("Done.");
            IsBusy = false;
        }

        private void AppendLine(string line)
        {
            _log.Write(line);
            Output += line + "\r\n";
        }

    }
}