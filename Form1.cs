using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    public partial class Form1 : Form, IController
    {
        private static Random r = new Random();
        private List<IView> views = new List<IView>();
        private IModel model;

        public Form1()
        {
            InitializeComponent();
            model = new MyModel();

            MyDataGrid dataGridView1 = new MyDataGrid()
            {
                Model = model
            };
            AddView(dataGridView1);

            PanelView panel1 = new PanelView
            {
                Model = model
            };
            AddView(panel1);

            IView labView = new LabelView(label1)
            {
                Model = model
            };
            AddView(labView);

            foreach (IView v in views) v.UpdateView();
        }

        public IModel Model { get => model; set => model = value; }

        public void Add() => model.AddNode(r.Next(100));

        public void AddView(IView v)
        {
            views.Add(v);
        }

        public void Remove()
        {
            if (model.Count > 0) model.RemoveLastNode();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add();
            foreach (IView v in views) v.UpdateView();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Remove();
            foreach (IView v in views) v.UpdateView();
        }
    }
}