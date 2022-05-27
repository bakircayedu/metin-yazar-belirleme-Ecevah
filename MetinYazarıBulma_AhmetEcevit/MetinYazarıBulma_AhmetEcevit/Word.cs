using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class Word
    {
        public string word { get; set; }
        public int wordNumber { get; set; }
        public Word(string word, int wordNumber)
        {
            this.word = word;
            this.wordNumber = wordNumber;
        }
    }
}
