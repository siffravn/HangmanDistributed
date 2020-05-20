using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Model
{
    class Words
    {
        public ArrayList WordList { get; set; } = new ArrayList();

        public Words()
        {
            WordList.Clear();
            WordList.Add("tommelfinger");
            WordList.Add("stjerne");
            WordList.Add("svane");
            WordList.Add("dagbog");
            WordList.Add("sahara");
            WordList.Add("mikroskop");
            WordList.Add("mayonaise");
            WordList.Add("arbejdskraft");
            WordList.Add("kanariefugl");
        }

        public string Random()
        {
            Random generator = new Random();
            int index = generator.Next(0, WordList.Count);

            return (string)WordList[index];
        }
    }
}
