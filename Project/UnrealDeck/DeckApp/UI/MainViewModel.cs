using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace DeckApp.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Domain.Workspaces.Workspace> Workspaces { get; } = new ObservableCollection<Domain.Workspaces.Workspace>();

        public MainViewModel()
        {
            Domain.Workspaces.WorkspaceID ID = new Domain.Workspaces.WorkspaceID("ID");
            Domain.Workspaces.WorkspaceDirectory Directory = new Domain.Workspaces.WorkspaceDirectory($"Directory");
            Workspaces.Add(new Domain.Workspaces.Workspace(ID, Directory));
        }

        // TODO: Replace to ICommand
        public void Add()
        {
            Domain.Workspaces.WorkspaceID ID = new Domain.Workspaces.WorkspaceID("ID");
            Domain.Workspaces.WorkspaceDirectory Directory = new Domain.Workspaces.WorkspaceDirectory($"Directory");
            Workspaces.Add(new Domain.Workspaces.Workspace(ID, Directory));

            Debug.WriteLine($"Add({Workspaces.Count})");

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Workspaces"));
        }
    }
}
