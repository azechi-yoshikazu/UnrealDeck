using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCore.Domain.Workspaces
{
    public class WorkspaceDirectory : IEquatable<WorkspaceDirectory>
    {
        public string Value { get; }

        public WorkspaceDirectory(string inValue)
        {
            Value = inValue;
        }

        public bool Equals(WorkspaceDirectory other)
        {
            return Value == other.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
