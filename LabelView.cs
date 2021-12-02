using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class LabelView : IView
    {
        private IModel model;
        private Label l;
        public IModel Model { get => model; set => model = value; }

        public LabelView(Label l)
        {
            this.l = l;
        }

        public void UpdateView() => l.Text = model.Count.ToString();
    }
}