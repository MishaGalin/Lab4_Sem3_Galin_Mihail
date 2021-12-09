using System;
using System.Collections.Generic;

namespace Lab3_Sem3_Galin_Mihail
{
    public interface IModel
    {
        event Action Changed;

        IEnumerable<Node> AllNodes { get; }

        int Count { get; }

        void AddNode(int value);

        void RemoveLastNode();

        void ColorNodes(int x, int y);
    }
}