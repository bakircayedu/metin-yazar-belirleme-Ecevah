using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class Heap
    {
        public HeapNode[] heap { get; set; }
        private int currentSize { get; set; }
        public int maxSize { get; set; }

        public Heap(int maxSize)
        {
            this.maxSize = maxSize;
            heap = new HeapNode[maxSize];
            currentSize = 0;
        }
        public bool IsEmpty()
        {
            if (currentSize == 0)
                return true;
            else
                return false;

        }
        public bool Add(string value)
        {
            if (currentSize == heap.Length)
                throw new IndexOutOfRangeException("overflow!");
            if (currentSize == maxSize)
                return false;

            for (int i = 0; i < currentSize; i++)
            {
                if (heap[i].value.word == value)
                {
                    heap[i].value.wordNumber++;
                    MoveToUp(i);
                    return true;
                }
            }
            Word a = new Word(value, 1);
            HeapNode HeapNode = new HeapNode(a);
            heap[currentSize] = HeapNode;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = heap[index];
            while (index > 0 && heap[parent].value.wordNumber < bottom.value.wordNumber)
            {
                heap[index] = heap[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heap[index] = bottom;
        }
        public HeapNode RemoveMax()
        {
            if (currentSize == 0)
                throw new IndexOutOfRangeException("underflow!");
            HeapNode root = heap[0];
            heap[0] = heap[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int child;
            HeapNode Head = heap[index];
            while (index < currentSize / 2)
            {
                int left = 2 * index + 1;
                int right = left + 1;
                if (right < currentSize && heap[left].value.wordNumber <
                heap[right].value.wordNumber)
                    child = right;
                else
                    child = left;
                if (Head.value.wordNumber >= heap[child].value.wordNumber)
                    break;
                heap[index] = heap[child];
                index = child;
            }
            heap[index] = Head;
        }

        public Word[] Sort()
        {
            Word[] sorted = new Word[currentSize];
            int i = 0;
            while (!IsEmpty())
                sorted[i++] = RemoveMax().value;
            return sorted;
        }
    }
}
