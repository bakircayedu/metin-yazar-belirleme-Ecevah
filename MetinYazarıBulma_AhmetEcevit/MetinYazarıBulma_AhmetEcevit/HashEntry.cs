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
    public class HashEntry
    {
        public string key { get; set; }
        public Object value { get; set; }
        public HashEntry Next { get; set; }
        public HashEntry(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.Next = null;
        }
    }
}
