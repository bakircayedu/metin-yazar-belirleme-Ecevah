using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
        public Node(object Data, Node Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
