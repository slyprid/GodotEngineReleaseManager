using Microsoft.UI.Xaml;
using Microsoft.Extensions.DependencyInjection;
using System;
using GERM.Views;
using GERM.Services;

namespace GERM
{
    public partial class App : Application
    {
        public static IServiceProvider? Services { get; private set; } = default;
        public static T GetService<T>() where T : notnull => (T)Services.GetRequiredService(typeof(T));

        private Window? _window;

        public App()
        {
            InitializeComponent();
            Services = ConfigureServices();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Windows / app services
            services.AddSingleton<MainWindow>();

            // App services (add your own later)
            services.AddSingleton<ILogService, LogService>();

            // ViewModels
            services.AddTransient<ViewModels.MainViewModel>();

            // Views (optional; many prefer not to register pages)
            //services.AddTransient<Views.ExportPage>();

            return services.BuildServiceProvider();
        }
        
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            _window = new MainWindow();
            _window.Activate();            
        }
    }
}
