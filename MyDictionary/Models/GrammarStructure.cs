using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class GrammarStructure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public GrammarStructure() { }
        public GrammarStructure(int id, string name, string notes)
        {
            Id = id;
            Name = name;
            Notes = notes;
        }
    }
}
