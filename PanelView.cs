using System.Drawing;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class PanelView : Panel, IView
    {
        private IModel model;
        public IModel Model { get => model; set => model = value; }

        public void UpdateView()
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes)
            {
                g.DrawEllipse(Pens.Red, n.X * 20, n.Y * 20, 20, 20);
            }
        }
    }
}