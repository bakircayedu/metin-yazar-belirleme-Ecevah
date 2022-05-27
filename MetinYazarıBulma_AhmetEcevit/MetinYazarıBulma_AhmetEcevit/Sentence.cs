using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class Sentence
    {
        public string text { get; set; }
        public int sentenceNumber { get; set; }
        public int wordNumber { get; set; }

        public Sentence(string text, int sentenceNumber, int wordNumber)
        {
            this.text = text;
            this.sentenceNumber = sentenceNumber;
            this.wordNumber = wordNumber;
        }
    }
}
