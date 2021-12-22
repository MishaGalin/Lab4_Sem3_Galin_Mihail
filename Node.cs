using System.Drawing;

namespace Lab3_Sem3_Galin_Mihail
{
    public class Node
    {
        private readonly int x, y;
        private Pen color = Pens.Red;

        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X => x;
        public int Y => y;
        public Pen Color { get => color; set => color = value; }
    }
}