using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class GrammarFomula
    {
        public int Id { get; set; }
        public int GrammarStructureId { get; set; }
        public GrammarStructure GrammarStructure
        {
            get { return GrammarStructure; }
            set
            {
                if (checkGrammarStructureId(value.Id))
                {
                    GrammarStructure = value;
                }
                else
                {
                    throw new Exception("GrammarStructureId is not valid");
                }
            }
        }
        public string Fomula { get; set; } //Công thức ngữ pháp

        public GrammarFomula() { }

        public GrammarFomula(int id, int grammarStructureId, GrammarStructure grammarStructure, string fomula)
        {
            Id = id;
            GrammarStructureId = grammarStructureId;
            GrammarStructure = grammarStructure;
            Fomula = fomula;
        }

        public bool checkGrammarStructureId(int grammarStructureId)
        {
            return GrammarStructureId == grammarStructureId;
        }

        //kiểm tra công thức ngữ pháp có đúng không
        public bool checkFomula(string fomula)
        {
            return Fomula == fomula;
        }
    }
}
