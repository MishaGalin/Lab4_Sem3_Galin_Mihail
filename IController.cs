using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sem3_Galin_Mihail
{
    internal interface IController
    {
        IModel Model { get; set; }

        void AddView(IView v);

        void Add();

        void Remove();
    }
}