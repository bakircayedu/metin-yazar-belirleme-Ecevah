using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class HashMap
    {
        public HashEntry[] Hash;
        public int size { get; set; }
        public HashMap(int Size)
        {
            size = Size;
            Hash = new HashEntry[Size];
            for (int i = 0; i < Size; i++)
            {
                Hash[i] = null;
            }
        }
        public Setting Search(string key)
        {
            int hash = HashValue(key) % size;
            if (Hash[hash] != null)
            {
                HashEntry Node = Hash[hash];
                while (Node.Next != null && Node.key != key)
                {
                    Node = Node.Next;
                }
                if (Node.key != key)
                {
                    return null;
                }
                return (Setting)Node.value;
            }
            else
                return null;
        }
        public void Add(string key,object value)
        {
            int hash = HashValue(key) % size;
            if (Hash[hash] != null)
            {
                HashEntry Node = Hash[hash];
                while (Node.Next != null)
                {
                    Node = Node.Next;
                }
                Node.Next = new HashEntry(key, value);
            }
            else
                Hash[hash] = new HashEntry(key, value);
        }
        public int HashValue(string key)
        {
            int hashValue = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashValue += key[i];
            }
            return hashValue;
        }
    }
}
