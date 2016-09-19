using System.Linq;
namespace _06_Book_Titles
{
    internal class Book
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                string[] skip = { "the", "a", "an", "and", "in", "of", "over" };
                string[] words = value.Split(' ');
                string newSentence = "";
                bool first = true;
                foreach (string word in words)
                {
                    if (first || !skip.Contains(word))
                    {
                        newSentence += char.ToUpper(word[0]) + word.Substring(1) + " ";
                    }
                    else
                    {
                        newSentence += word + " ";
                    }
                    first = false;
                }
                newSentence = newSentence.Trim();
                this.title = newSentence;

            }
        }
    }
    }

