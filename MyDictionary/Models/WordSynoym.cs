using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class WordSynoym
    {
        public int Word_Id {
            get { return Word_Id; }
            set
            {
                if(checkWord_Id(value))
                {
                    Word_Id = value;
                }
            }
        }
        public Word Word { get; set; }
        public int Synonym_Id {
            get { return Synonym_Id; }
            set
            {
                if (checkSynonym_Id(value))
                {
                    Synonym_Id = value;
                }
            }
        }
        public SynoymGroup SynonymGr { get; set; }

        public WordSynoym()
        {
        }

        public WordSynoym(int word_Id, Word word, int synonym_Id, SynoymGroup synonymGr)
        {
            Word_Id = word_Id;
            Word = word;
            Synonym_Id = synonym_Id;
            SynonymGr = synonymGr;
        }

        public bool checkWord_Id(int word_Id)
        {
            return Word_Id == word_Id;
        }

        public bool checkSynonym_Id(int synonym_Id)
        {
            return Synonym_Id == synonym_Id;
        }
    }
}
