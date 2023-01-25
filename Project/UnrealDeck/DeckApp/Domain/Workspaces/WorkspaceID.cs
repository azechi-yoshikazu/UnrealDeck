using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckApp.Domain.Workspaces
{
    public class WorkspaceID : IEquatable<WorkspaceID>
    {
        public string Value { get; }

        public WorkspaceID(string inValue)
        {
            Value = inValue;
        }

        public bool Equals(WorkspaceID other)
        {
            return Value == other.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
