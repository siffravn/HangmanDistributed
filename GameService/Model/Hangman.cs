using System;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Model
{
    [DataContract]
    public class Hangman
    {
        [DataMember] 
        public string HiddenWord { get; set; }

        [DataMember]
        public string VisibleWord { get; set; }

        [DataMember]
        public int Lives { get; set; }

        [DataMember]
        public ArrayList UsedLetters { get; set; } = new ArrayList();

        [DataMember]
        public bool IsGameWon { get; set; }

        [DataMember]
        public bool IsGameLost { get; set; }

        [DataMember]
        public bool IsGuessCorrect { get; set; }


        public Hangman()
        {
            Reset();
            HiddenWord = "test";
        }

        public void Guess(string guess)
        {
            guess = guess.ToLower();
            if (guess.Length > 1)
            {
                GuessWord(guess);
            }
            else if (UsedLetters.Contains(guess)) return;
            else
            {
                UsedLetters.Add(guess);
                UsedLetters.Sort();
                GuessLetter(guess);
            }
            if (VisibleWord == HiddenWord) IsGameWon = true;
            else if (Lives < 1) IsGameLost = true;
        }

        private void GuessLetter(string guess)
        {
            if (HiddenWord.Contains(guess))
            {
                UpdateVisibleWord(guess);
                IsGuessCorrect = true;
            }
            else Lives--;
        }

        private void GuessWord(string guess)
        {
            if (HiddenWord == guess)
            {
                VisibleWord = HiddenWord;
                IsGuessCorrect = true;
            }
            else Lives -= 2;
        }

        private void UpdateVisibleWord(string guess)
        {
            char letter = char.Parse(guess);
            StringBuilder stringBuilder = new StringBuilder(VisibleWord);
            for (int i = 0; i < HiddenWord.Length; i++)
            {
                if (HiddenWord[i] == letter)
                {
                    stringBuilder[i] = letter;
                }
            }
            VisibleWord = stringBuilder.ToString();
        }

        public bool IsGameFinished() { return IsGameWon || IsGameLost; }

        public void Reset()
        {
            UsedLetters.Clear();
            Lives = 7;
            IsGameWon = false;
            IsGameLost = false;
        }

        public void setHiddenWord(string word)
        {
            GenerateVisibleWord(word.Length);
            HiddenWord = word.ToLower();
        }

        private void GenerateVisibleWord(int length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append("*");
            }
            VisibleWord = stringBuilder.ToString();
        }

        public String Status()
        {
            StringBuilder status = new StringBuilder();
            status.Append("Visible word: " + VisibleWord + "\n");
            status.Append("Lives left: " + Lives + "\n");
            status.Append("Used letters: " + string.Join(" ", UsedLetters.ToArray()) + "\n");

            return status.ToString();
        }
    }
}
