using System.Windows;
using System.Diagnostics;
using DeckCore.Application.Workspaces;

namespace DeckApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int incrementalID = 0;

        private WorkspaceService service;

        public MainWindow()
        {
            InitializeComponent();

            service = new WorkspaceService(new DeckCore.StubInfraStructure.InMemoryWorkspaceRepository());
        }

        private void OnAddWorkspaceButtonClicked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Add workspace");
            {
                DeckCore.Domain.Workspaces.WorkspaceID ID = new DeckCore.Domain.Workspaces.WorkspaceID($"ID_{incrementalID}");
                DeckCore.Domain.Workspaces.WorkspaceDirectory Directory = new DeckCore.Domain.Workspaces.WorkspaceDirectory($"Dir_{incrementalID}");
                DeckCore.Domain.Workspaces.Workspace newWorkspace = new DeckCore.Domain.Workspaces.Workspace(ID, Directory);

                var result = service.Create(newWorkspace);

                if (result.Item1)
                {
                    foreach (var workspace in result.Item2)
                    {
                        Debug.WriteLine(workspace);
                    }
                }

                incrementalID++;
            }
        }
    }
}
