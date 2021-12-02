using System;
using System.Collections.Generic;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class MyModel : IModel
    {
        private static Random r = new Random();
        private LinkedList<Node> nodes = new LinkedList<Node>();

        public IEnumerable<Node> AllNodes => nodes;
        public int Count => nodes.Count;

        public event Action Changed;

        public void AddNode(int value)
        {
            nodes.AddFirst(new Node(value, r.Next(10), r.Next(10)));
            Changed?.Invoke();
        }

        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            Changed?.Invoke();
        }
    }
}