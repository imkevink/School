using System;
using System.Collections.Generic;

namespace Opdracht_4
{
    public class LingoGame
    {
        public string lingoWord;
        public string playerWord;
        public LetterState[] letterResults = new LetterState[5];

        public void Init(string word)
        {
            lingoWord = word;
        }

        public bool GuessedWord()
        {
            return lingoWord == playerWord;
        }

        public void CheckWord()
        {
            List<char> letters = new List<char>();

            for (int i = 0; i < 5; i++)
            {
                if (lingoWord[i] != playerWord[i])
                    letters.Add(lingoWord[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                if (lingoWord[i] == playerWord[i])
                    letterResults[i] = LetterState.Correct;
                else
                {
                    if (letters.Contains(playerWord[i]))
                    {
                        letterResults[i] = LetterState.WrongPosition;
                        letters.Remove(playerWord[i]);
                    }
                    else
                        letterResults[i] = LetterState.Incorrect;
                }
            }
        }
    }

    public enum LetterState
    {
        Correct,
        Incorrect,
        WrongPosition,
    }
}
