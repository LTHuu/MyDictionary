using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class WordBase
    {
        public string Text { get; set; }
        public string Note { get; set; }

        public WordBase() { }

        public WordBase(string text, string note)
        {
            Text = text;
            Note = note;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
