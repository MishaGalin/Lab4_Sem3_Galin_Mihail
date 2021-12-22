using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    internal delegate void ClickedXY(int x, int y);

    internal class MyDataGrid : DataGridView, IView
    {
        public event ClickedXY ClickedXY;

        public IModel Model { get; set; }

        public void UpdateView()
        {
            AutoGenerateColumns = true; // в таблице будут все public-свойства узлов
            DataSource = Model.AllNodes.ToArray();
        }
    }
}