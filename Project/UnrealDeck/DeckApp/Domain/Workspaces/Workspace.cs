using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckApp.Domain.Workspaces
{
    public class Workspace
    {
        public WorkspaceID ID { get; }
        public WorkspaceDirectory Directory { get; }

        public Workspace(WorkspaceID inID, WorkspaceDirectory inDirectory)
        {
            ID = inID;
            Directory = inDirectory;
        }

        public override string ToString()
        {
            return $"ID:{ID} Dir:{Directory}";
        }
    }
}
