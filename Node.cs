using System.Drawing;

namespace Lab3_Sem3_Galin_Mihail
{
    public class Node
    {
        private int x, y, value;
        private Pen color = Pens.Red;

        public Node(int value, int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; }
        public int Y { get => y; }
        public Pen Color { get => color; set => color = value; }
    }
}