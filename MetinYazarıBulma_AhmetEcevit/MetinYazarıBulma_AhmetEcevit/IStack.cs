using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public interface IStack
    {
        void Push(object item);
        object Pop();
        object Peek();
        bool IsEmpty();
        Node Head { get; set; }
    }
}
