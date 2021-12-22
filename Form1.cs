using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    public partial class Form1 : Form, IController
    {
        private static readonly Random r = new Random();
        private IModel model;

        public Form1()
        {
            InitializeComponent();
            model = new MyModel();

            IView labView = new LabelView(label1)
            {
                Model = model
            };

            dataGridView1.ClickedXY += DataGridView1_ClickedXY;
            dataGridView1.Model = model;
            panel1.Model = model;

            AddView(labView);
            AddView(dataGridView1);
            AddView(panel1);
        }

        private void DataGridView1_ClickedXY(int x, int y)
        {
            model.ColorNodes(x, y);
        }

        public IModel Model { get => model; set => model = value; }

        public void Add() => model.AddNode();

        public void AddView(IView v) => model.Changed += new Action(v.UpdateView);

        public void Remove()
        {
            if (model.Count > 0) model.RemoveLastNode();
        }

        private void AddButton_Click(object sender, EventArgs e) => Add();

        private void RemoveButton_Click(object sender, EventArgs e) => Remove();

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            => DataGridView1_ClickedXY(e.X, (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value);
    }
}