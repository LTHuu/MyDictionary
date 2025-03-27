using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary.Models
{
    public class Word_WordType
    {
        public string Word_Id { 
            get { return Word_Id; }
            set
            {
                if(checkWord_Id(value))
                {
                    Word_Id = value;
                } else
                {
                    MessageBox.Show("Word_Id is not valid");
                }
            }
        }
        public Word Word { get; set; }
        public string WordType_Id { 
            get { return WordType_Id; }
            set
            {
                if (checkWordType_Id(value))
                {
                    WordType_Id = value;
                }
                else
                {
                    MessageBox.Show("WordType_Id is not valid");
                }
            }
        }
        public WordType WordType { get; set; }

        public Word_WordType() { }

        public Word_WordType(string word_Id, string wordType_Id)
        {
            Word_Id = word_Id;
            //get WordById
            WordType_Id = wordType_Id;
            //get WordTypeById
        }

        public Word_WordType(Word word, WordType wordType)
        {
            Word = word;
            WordType = wordType;
        }

        public bool checkWord_Id(string id)
        {
            return true;
        }

        public bool checkWordType_Id(string id)
        {
            return true;
        }
    }
}
