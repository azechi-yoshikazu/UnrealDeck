using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace DeckApp.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Domain.Workspaces.Workspace> Workspaces { get; } = new List<Domain.Workspaces.Workspace>();

        public MainViewModel()
        {
            Domain.Workspaces.WorkspaceID ID = new Domain.Workspaces.WorkspaceID("ID");
            Domain.Workspaces.WorkspaceDirectory Directory = new Domain.Workspaces.WorkspaceDirectory($"Directory");
            Workspaces.Add(new Domain.Workspaces.Workspace(ID, Directory));
        }
    }
}
