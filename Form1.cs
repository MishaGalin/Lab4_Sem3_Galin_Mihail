using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    public partial class Form1 : Form, IController
    {
        private static Random r = new Random();
        private List<IView> views = new List<IView>();
        public IModel model;

        public Form1()
        {
            InitializeComponent();

            IView labView = new LabelView(label1);
            model = new MyModel();
            labView.Model = model;
            AddView(labView);
        }

        public IModel Model { get => model; set => model = value; }

        public void Add() => model.AddNode(r.Next(100));

        public void AddView(IView v) => views.Add(v);

        public void Remove() => model.RemoveLastNode();

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}