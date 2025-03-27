using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary.Models
{
    public class WordType : WordBase
    {
        public int Id { get; set; }
        public string Short { get; set; }
        public int ParentId {
            get { return ParentId; }
            set { 
                if(checkParentId(value))
                {
                    ParentId = value;
                }
                else
                {
                    MessageBox.Show("ParentId is not valid");
                }
            } 
        }

        public WordType() { }

        public WordType(int id, string text, string note, string shortName)
        {
            Id = id;
            Text = text;
            Note = note;
            Short = shortName;
        }

        public bool checkParentId(int id)
        {
            return true;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
