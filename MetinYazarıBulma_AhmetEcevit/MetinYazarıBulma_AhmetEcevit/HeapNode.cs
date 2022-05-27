using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class HeapNode
    {
        public Word value { get; set; }
        public HeapNode Left { get; set; }
        public HeapNode Right { get; set; }
        public HeapNode(Word value)
        {
            this.value = value;
            Right = null;
            Left = null;
        }
    }
}
