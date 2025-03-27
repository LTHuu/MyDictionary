using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class Options
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OptionCode { get; set; }
        public string TypeOption { get; set; }
        public string Note { get; set; }

        public Options() { }

        public Options(int id, string name, string optionCode, string typeOption, string note)
        {
            Id = id;
            Name = name;
            OptionCode = optionCode;
            TypeOption = typeOption;
            Note = note;
        }
    }
}
