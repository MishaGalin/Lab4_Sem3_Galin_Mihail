using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class MyModel : IModel
    {
        private static Random r = new Random();
        private LinkedList<Node> nodes = new LinkedList<Node>();

        public int Count => nodes.Count;

        public void AddNode(int value) => nodes.AddFirst(new Node(value, r.Next(10), r.Next(10)));

        public void RemoveLastNode() => nodes.RemoveLast();
    }
}