using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class GrammarPart
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public Word Word {
            get { return Word; }
            set
            {
                if (checkWordId(value.Id))
                {
                    Word = value;
                }
                else
                {
                    throw new Exception("WordId is not valid");
                }
            }
        }
        public int WordTypeId { get; set; }
        public WordType WordType {
            get { return WordType; }
            set
            {
                if (checkWordTypeId(value.Id))
                {
                    WordType = value;
                }
                else
                {
                    throw new Exception("WordTypeId is not valid");
                }
            }
        }

        public GrammarPart() { }

        public GrammarPart(int id, int wordId, Word word, int wordTypeId, WordType wordType)
        {
            Id = id;
            WordId = wordId;
            Word = word;
            WordTypeId = wordTypeId;
            WordType = wordType;
        }

        public bool checkWordId(int wordId)
        {
            return WordId == wordId;
        }

        public bool checkWordTypeId(int wordTypeId)
        {
            return WordTypeId == wordTypeId;
        }
    }
}
