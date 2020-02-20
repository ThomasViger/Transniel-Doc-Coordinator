using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using NielTransport.DocCoordinator.Core.ExternalServices;
using NielTransport.DocCoordinator.Core.UseCases;
using NielTransport.DocCoordinator.Infrastructure;

namespace NielTransport.DocCoordinator.WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IOcrService, OcrService>();
            services.AddScoped<IPdfService, PdfService>();
            services.AddScoped<MergePdfUseCase>();
            services.AddScoped<MainWindow>();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}