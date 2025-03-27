using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class Frequency
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }

        public Frequency() { }

        public Frequency(int id, int level, string description)
        {
            Id = id;
            Level = level;
            Description = description;
        }
    }
}
