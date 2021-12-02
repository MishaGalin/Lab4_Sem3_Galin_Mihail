using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class LabelView : IView
    {
        private Label l;
        private IModel model;

        public LabelView(Label l)
        {
            this.l = l;
        }

        public IModel Model { get => model; set => model = value; }

        public void UpdateView() => l.Text = model.Count.ToString();
    }
}