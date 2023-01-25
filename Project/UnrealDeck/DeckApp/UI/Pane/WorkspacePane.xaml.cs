using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace DeckApp.UI.Pane
{
    /// <summary>
    /// Interaction logic for WorkspacePane.xaml
    /// </summary>
    public partial class WorkspacePane : UserControl
    {
        public WorkspacePane()
        {
            InitializeComponent();
        }

        private void OnAddWorkspaceButtonClicked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Add workspace");
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
