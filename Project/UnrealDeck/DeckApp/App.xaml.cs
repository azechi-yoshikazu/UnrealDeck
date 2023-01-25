using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace DeckApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private ServiceCollection services = new ServiceCollection();

        protected override void OnStartup(StartupEventArgs e)
        {
            ConfigurateServices();

            MainWindow = new MainWindow(services.BuildServiceProvider());
            MainWindow.Show();
        }

        private void ConfigurateServices()
        {
            services.AddSingleton<Domain.Workspaces.IWorkspaceRepository, StubInfraStructure.InMemoryWorkspaceRepository>();
            services.AddTransient<Application.Workspaces.WorkspaceService>();
        }
    }
}
