using System.Collections.Generic;

namespace Lab3_Sem3_Galin_Mihail
{
    public interface IModel
    {
        IEnumerable<Node> AllNodes { get; }

        int Count { get; }

        void AddNode(int value);

        void RemoveLastNode();
    }
}