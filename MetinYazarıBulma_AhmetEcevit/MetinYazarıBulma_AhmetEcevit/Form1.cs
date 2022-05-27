using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinYazarıBulma_AhmetEcevit
{
    public partial class frmVeriYapilari : Form
    {
        public frmVeriYapilari()
        {
            InitializeComponent();
        }
        Setting setting = new Setting();
        Heap heap;
        Word[] words;
        private void frmVeriYapilari_Load(object sender, EventArgs e)
        {
            btnFav.Enabled = false;
            btnStack.Enabled = false;
            btnSearch.Enabled = false;
            btnTree.Enabled = false;
            btnHash.Enabled = false;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "(*.txt)|*.txt";
            file.ShowDialog();

            Stream File = file.OpenFile();
            StreamReader reader = new StreamReader(File);
            setting.tempText = reader.ReadToEnd();
            txtFile.Text = file.FileName;

            btnFile.Enabled = false;
            btnStack.Enabled = true;
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack sentenceStack = new Stack();
            setting.sentences = Regex.Split(setting.tempText, setting.bat);
            int sentenceNumber = setting.sentences.Length;


            for (int i = 0; i < sentenceNumber; i++)
            {
                int wordNumber = Regex.Split(setting.sentences[i], " ").Length;
                Sentence sentence = new Sentence(setting.sentences[i], i + 1, wordNumber);
                sentenceStack.Push(sentence);
            }

            Stack temp = new Stack();
            while (!sentenceStack.IsEmpty())
            {
                temp.Push(sentenceStack.Peek());
                Sentence sentence = (Sentence)sentenceStack.Pop();
                setting.output(sentence.wordNumber, sentence.text);
                lbSentence.Items.Add(setting.Output);
            }

            while (!temp.IsEmpty())
            {
                Sentence tempSentence = (Sentence)temp.Peek();
                setting.tWord += tempSentence.wordNumber;
                setting.tSentence++;
                sentenceStack.Push(temp.Pop());
            }
            setting.Calculation();
            setting.output2(setting.tWord, setting.tSentence, setting.average);
            lbSentence.Items.Add(setting.Output2);
            btnStack.Enabled = false;
            btnTree.Enabled = true;
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            setting.rafinedWord = Regex.Replace(setting.tempText, setting.fat, " ");
            setting.rafinedWord = Regex.Replace(setting.rafinedWord, setting.pattern, "").ToLower();
            string[] words = setting.rafinedWord.Split(' ');

            heap = new Heap(words.Length);
            for (int i = 0; i < words.Length; i++)
                heap.Add(words[i]);

            btnTree.Enabled = false;
            btnFav.Enabled = true;
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            words = heap.Sort();
            foreach (var fav in words) {
                setting.FavF(fav.wordNumber, fav.word);
                lbWord.Items.Add(setting.Fav);
            }
            btnFav.Enabled=false;
            btnHash.Enabled = true;
        }
        HashMap HashMap;
        private void btnHash_Click(object sender, EventArgs e)
        {
            HashMap hash = new HashMap(words.Length);
            foreach (var item in words)
                hash.Add(item.word, item);

            btnHash.Enabled=false;
            btnFile.Enabled = true;
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = Regex.Replace(txtSearch.Text, @"\W(?=\s)|(?<=[ ])\W+|'\w+", "").ToLower();
            Setting setting = HashMap.Search(searchWord);
            lblWord.Text = "Kelime: " + setting.usedWord;
            lblNumber.Text = "Kullanım Sayısı: " + setting.usedWordNumber.ToString();
        }
    }
}
