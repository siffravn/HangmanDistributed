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
            WordList.Add("car");
            WordList.Add("computer");
            WordList.Add("programming");
            WordList.Add("highway");
            WordList.Add("busride");
            WordList.Add("pavement");
            WordList.Add("slug");
            WordList.Add("blackbird");
            WordList.Add("nineteen");
        }

        public string Random()
        {
            Random generator = new Random();
            int index = generator.Next(0, WordList.Count);

            return (string)WordList[index];
        }
    }
}
