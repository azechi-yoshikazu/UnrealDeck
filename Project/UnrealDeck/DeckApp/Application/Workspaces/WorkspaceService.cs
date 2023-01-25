using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckApp.Application.Workspaces
{
    public class WorkspaceService
    {
        private readonly Domain.Workspaces.IWorkspaceRepository repository = null;
        private readonly Domain.Workspaces.WorkspaceService service;

        public WorkspaceService(Domain.Workspaces.IWorkspaceRepository repository)
        {
            this.repository = repository;
            service = new Domain.Workspaces.WorkspaceService(repository);
        }

        public (bool, IList<Domain.Workspaces.Workspace>) Create(Domain.Workspaces.Workspace workspace)
        {
            if(service.IsRegistered(workspace) || !repository.Save(workspace))
            {
                return (false, null);
            }

            return (true, repository.QueryAll());
        }

    }
}
