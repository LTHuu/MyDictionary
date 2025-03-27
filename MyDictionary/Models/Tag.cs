using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public Tag() { }

        public Tag(int id, string name, string note)
        {
            Id = id;
            Name = name;
            Note = note;
        }
    }
}
