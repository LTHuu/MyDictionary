using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class Antonym
    {
        public int Word_Id {
            get { return this.Word_Id; }
            set
            {
                if (checkWord_Id(value))
                {
                    this.Word_Id = value;
                }
            }
        }
        public Word Word { get; set; }
        public int Antonym_Id
        {
            get { return this.Antonym_Id; }
            set
            {
                if (checkAntonym_Id(value))
                {
                    this.Antonym_Id = value;
                }
            }
        }
        public Word Word_Antonym { get; set; }

        public bool checkWord_Id(int word_Id)
        {
            return this.Word_Id == word_Id;
        }

        public bool checkAntonym_Id(int antonym_Id)
        {
            return this.Antonym_Id == antonym_Id;
        }
    }
}
