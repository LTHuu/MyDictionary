using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary.Models
{
    public class Word : WordBase
    {
        public int Id { get; set; }
        public int FrequencyId
        {
            get { return this.FrequencyId; }
            set
            {
                if (checkFrequencyId(value))
                {
                    this.FrequencyId = value;
                }
                else
                    MessageBox.Show("FrequencyId không hợp lệ");
            }
        }
        public Frequency Frequency { get; set; }

        public Word() { }

        public Word(int id,string text, string note, int frequencyId, Frequency frequency)
        {
            Id = id;
            Text = text;
            Note = note;
            FrequencyId = frequencyId;
            Frequency = frequency;
        }

        public bool checkFrequencyId(int value)
        {
            if (value < 1 || value > 5)
                return false;
            return true;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
       