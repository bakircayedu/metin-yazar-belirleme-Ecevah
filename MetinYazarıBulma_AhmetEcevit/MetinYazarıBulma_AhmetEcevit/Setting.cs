using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazarıBulma_AhmetEcevit
{
    public class Setting
    {
        public string usedWord { get; set; }
        public int usedWordNumber { get; set; }
        public string tempText { get; set; }
        public string[] sentences { get; set; }
        public int tWord = 0;
        public int tSentence = 0;
        public int average { get; set; }
        public string rafinedWord { get; set; }
        public string Output { get; set; }
        public string Output2 { get; set; }
        public string Fav { get; set; }
        public void Calculation()
        {
            average = tWord / tSentence;
        }
        public void output(int number, string word)
        {
            Output = number + "\t" + word;
        }
        public void output2(int word, int sentence, int avarage)
        {
            Output2 = "Kelime Sayısı: " + word + "\t" +
                "Cümle Sayısı: " + sentence + "\t" +
                "Ortalama Kelime Sayısı: " + average;
        }
        public void FavF(int number,string word) 
        {
            Fav = "Frekans : " + number + "\t" + "Kelime : " + word;
        }
    }
}
