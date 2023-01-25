using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckApp.Domain.Workspaces
{
    public interface IWorkspaceRepository
    {
        public bool Save(Workspace workspace);
        public bool Delete(Workspace workspace);

        public Workspace Find(WorkspaceID ID);
        public IList<Workspace> QueryAll();
    }
}
