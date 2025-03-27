using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary.Models
{
    public class Tag_Options
    {
        public int TagId { 
            get { return TagId; }
            set
            {
                if(checkTagId(value))
                {
                    TagId = value;
                } else
                {
                    MessageBox.Show("Invalid TagId");
                }
            }
        }
        public Tag Tag { get; set; }
        public int OptionId {
            get { return OptionId; }
            set
            {
                if (checkOptionId(value))
                {
                    OptionId = value;
                }
                else
                {
                    MessageBox.Show("Invalid OptionId");
                }
            }
        }
        public Options Option { get; set; }
        public Tag_Options() { }
        
        public Tag_Options(int tagId, Tag tag, int optionId, Options option)
        {
            TagId = tagId;
            Tag = tag;
            OptionId = optionId;
            Option = option;
        }

        public bool checkTagId(int tagId)
        {
            return TagId == tagId;
        }

        public bool checkOptionId(int optionId)
        {
            return OptionId == optionId;
        }
    }
}
