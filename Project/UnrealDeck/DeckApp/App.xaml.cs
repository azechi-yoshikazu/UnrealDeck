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
        public IServiceProvider Services { get; }

        public new static App Current => (App)System.Windows.Application.Current;

        public App()
        {
            Services = ConfigureServices();

            InitializeComponent();
        }

        private IServiceProvider ConfigureServices()
        {
            ServiceCollection collection = new ServiceCollection();

            collection.AddSingleton<Domain.Workspaces.IWorkspaceRepository, StubInfraStructure.InMemoryWorkspaceRepository>();
            collection.AddSingleton<Application.Workspaces.WorkspaceService>();

            collection.AddTransient<UI.MainViewModel>();

            return collection.BuildServiceProvider();
        }
    }
}
