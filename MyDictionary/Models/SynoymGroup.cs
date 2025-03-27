using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class SynoymGroup
    {
        public int Id { get; set; }
        public string Mean { get; set; }

        public SynoymGroup() { }

        public SynoymGroup(int id, string mean)
        {
            Id = id;
            Mean = mean;
        }
    }
}
