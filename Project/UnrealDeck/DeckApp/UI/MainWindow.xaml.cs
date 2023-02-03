using System.Windows;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace DeckApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OnAddWorkspaceButtonClicked(object sender, RoutedEventArgs e)
        {
            //Debug.WriteLine("Add workspace");
            //{
            //    Domain.Workspaces.WorkspaceID ID = new Domain.Workspaces.WorkspaceID($"ID_{incrementalID}");
            //    Domain.Workspaces.WorkspaceDirectory Directory = new Domain.Workspaces.WorkspaceDirectory($"Dir_{incrementalID}");
            //    Domain.Workspaces.Workspace newWorkspace = new Domain.Workspaces.Workspace(ID, Directory);

            //    var service = serviceProvider.GetRequiredService<Application.Workspaces.WorkspaceService>();
            //    var result = service.Create(newWorkspace);

            //    if (result.Item1)
            //    {
            //        foreach (var workspace in result.Item2)
            //        {
            //            Debug.WriteLine(workspace);
            //        }
            //    }

            //    incrementalID++;
            //}
        }
    }
}
