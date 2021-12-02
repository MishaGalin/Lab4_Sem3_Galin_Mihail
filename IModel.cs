using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sem3_Galin_Mihail
{
    internal interface IModel
    {
        void AddNode(int value);

        void RemoveLastNode();

        int Count { get; }
    }
}