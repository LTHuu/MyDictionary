using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string imgPath { get; set; }
        public string Note { get; set; }

        public Topic() { }

        public Topic(int id, string name, string imgPath, string note)
        {
            Id = id;
            Name = name;
            this.imgPath = imgPath;
            Note = note;
        }
    }
}
