using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class Node
    {
        private int x, y, value;

        public Node(int value, int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Value = value;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Value { get => value; set => this.value = value; }
    }
}