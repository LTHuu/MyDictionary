using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserInfo()
        {
        }

        public UserInfo(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
