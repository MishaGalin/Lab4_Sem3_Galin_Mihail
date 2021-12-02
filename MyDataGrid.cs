using System.Linq;
using System.Windows.Forms;

namespace Lab3_Sem3_Galin_Mihail
{
    internal class MyDataGrid : DataGridView, IView
    {
        public IModel Model { get; set; }

        public void UpdateView()
        {
            AutoGenerateColumns = true; // в таблице будут все public-свойства узлов
            DataSource = Model.AllNodes.ToArray();
        }
    }
}