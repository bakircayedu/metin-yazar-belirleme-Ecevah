using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class Stack : IStack
    {
        public Node Head { get; set; }

        public int count { get; set; }

        public Stack()
        {
            Head = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            if (Head == null)
                return true;
            else
                return false;
        }

        public object Peek()
        {
            if (count == 0)
                throw new Exception();
            return Head.Data;
        }

        public object Pop()
        {
            if (count == 0)
                throw new Exception();
            object deleted = Head.Data;
            Head = Head.Next;
            count = count - 1;
            return deleted;
        }

        public void Push(object item)
        {
            if (item == null)
                throw new Exception();
            Node Node = new Node(item, Head);
            Head = Node;
            count = count + 1;
        }
    }
}
