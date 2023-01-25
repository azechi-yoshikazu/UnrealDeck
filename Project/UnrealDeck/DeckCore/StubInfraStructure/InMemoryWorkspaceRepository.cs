using System;
using System.Collections.Generic;
using System.Linq;
using DeckCore.Domain.Workspaces;

namespace DeckCore.StubInfraStructure
{
    public class InMemoryWorkspaceRepository : IWorkspaceRepository
    {
        private IList<Workspace> workspaces = new List<Workspace>();

        public bool Save(Workspace workspace)
        {
            workspaces.Add(workspace);

            return true;
        }

        public bool Delete(Workspace workspace)
        {
            return workspaces.Remove(workspace);
        }

        public Workspace Find(WorkspaceID ID)
        {
            return workspaces.Where(workspace => workspace.ID == ID).FirstOrDefault();
        }

        public IList<Workspace> QueryAll()
        {
            return workspaces;
        }
    }
}
