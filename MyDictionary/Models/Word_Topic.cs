using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary.Models
{
    public class Word_Topic
    {
        public int Word_Id {
            get { return Word_Id; }
            set
            {
                if (checkWordId(value))
                {
                    this.Word_Id = value;
                }
                else
                {
                    MessageBox.Show("Word_Id không hợp lệ");
                }
            }
        }
        public Word Word { get; set; }
        public int Topic_Id { 
            get { return Word_Id; }
            set
            {
                if (checkTopicId(value))
                {
                    this.Topic_Id = value;
                }
                else
                {
                    MessageBox.Show("Topic_Id không hợp lệ");
                }
            }
        }
        public Topic Topic { get; set; }

        public Word_Topic() { }

        public Word_Topic(int word_Id, Word word, int topic_Id, Topic topic)
        {
            Word_Id = word_Id;
            Word = word;
            Topic_Id = topic_Id;
            Topic = topic;
        }

        public bool checkWordId(int value)
        {
            if (value < 1)
                return false;
            return true;
        }

        public bool checkTopicId(int value)
        {
            if (value < 1)
                return false;
            return true;
        }
    }
}
