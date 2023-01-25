using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCore.Domain.Workspaces
{
    public class WorkspaceService
    {
        private readonly IWorkspaceRepository repository = null;

        public WorkspaceService(IWorkspaceRepository repository)
        {
            this.repository = repository;
        }

        public bool IsRegistered(Workspace workspace)
        {
            Workspace foundWorkspace = repository.Find(workspace.ID);

            return foundWorkspace != null;
        }
    }
}
