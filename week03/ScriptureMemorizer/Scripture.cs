using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            foreach (string word in text.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random rand = new Random();
            int hiddenCount = 0;
            while (hiddenCount < numberToHide)
            {
                int index = rand.Next(_words.Count);
                if (!_words[index].IsHidden)
                {
                    _words[index].Hide();
                    hiddenCount++;
                }

                // To break if all words are hidden
                if (IsCompletelyHidden()) break;
            }

        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden)
                    return false;
            }
            return true;
        }

        public string GetDisplayText()
        {
            string display = _reference.GetDisplayText() + " ";
            foreach (Word word in _words)
            {
                display += word.GetDisplayText() + " ";
            }
            return display.Trim();
        }

        public override string ToString() => GetDisplayText();   

    }
}