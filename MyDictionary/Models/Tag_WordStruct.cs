using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class Tag_WordStruct
    {
        public int TagId
        {
            get { return TagId; }
            set
            {
                if (checkTagId(value))
                {
                    TagId = value;
                }
                else
                {
                    throw new Exception("Invalid TagId");
                }
            }
        }
        public Tag Tag { get; set; }
        public int WordStructId
        {
            get { return WordStructId; }
            set
            {
                if (checkWordStructId(value))
                {
                    WordStructId = value;
                }
                else
                {
                    throw new Exception("Invalid WordStructId");
                }
            }
        }
        public GrammarFomula WordStruct { get; set; }
        public Tag_WordStruct() { }

        public Tag_WordStruct(int tagId, Tag tag, int wordStructId, GrammarFomula wordStruct)
        {
            TagId = tagId;
            Tag = tag;
            WordStructId = wordStructId;
            WordStruct = wordStruct;
        }
        public bool checkTagId(int tagId)
        {
            return TagId == tagId;
        }
        public bool checkWordStructId(int wordStructId)
        {
            return WordStructId == wordStructId;
        }
    }
}
