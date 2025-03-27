using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Models
{
    public class GrammarStructure_Part
    {
        public  int GrammarFormulaId {
            get { return GrammarFormulaId; }
            set
            {
                if (checkGrammarFormulaId(value))
                {
                    GrammarFormulaId = value;
                }
                else
                {
                    throw new Exception("GrammarFormulaId is not valid");
                }
            }
        }
        public GrammarFomula GrammarFomula { get; set; }
        public int GrammarPartId {
            get { return GrammarPartId; }
            set
            {
                if (checkGrammarPartId(value))
                {
                    GrammarPartId = value;
                }
                else
                {
                    throw new Exception("GrammarPartId is not valid");
                }
            }
        }
        public GrammarPart GrammarPart { get; set; }
        public int Position { get; set; }

        public GrammarStructure_Part() { }

        public GrammarStructure_Part(int grammarFormulaId, GrammarFomula grammarFomula, int grammarPartId, GrammarPart grammarPart, int position)
        {
            GrammarFormulaId = grammarFormulaId;
            GrammarFomula = grammarFomula;
            GrammarPartId = grammarPartId;
            GrammarPart = grammarPart;
            Position = position;
        }

        public bool checkGrammarFormulaId(int grammarFormulaId)
        {
            return GrammarFormulaId == grammarFormulaId;
        }

        public bool checkGrammarPartId(int grammarPartId)
        {
            return GrammarPartId == grammarPartId;
        }

    }
}
