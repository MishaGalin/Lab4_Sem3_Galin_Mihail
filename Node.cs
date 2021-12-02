namespace Lab3_Sem3_Galin_Mihail
{
    public class Node
    {
        private int x, y, value;

        public Node(int value, int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Value { get => value; set => this.value = value; }
        public int X { get => x; }
        public int Y { get => y; }
    }
}