using System;
using System.Collections.Generic;

namespace WordScrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildmatchedWord(scrambledWord, word));
                    }
                    else
                    {
                        var scrambredWordArray = scrambledWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambredWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambredWordArray);
                        var sortedWord = new string(wordArray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildmatchedWord(scrambledWord, word));
                        }
                    }
                }
            }

            return matchedWords;
        }

        private MatchedWord BuildmatchedWord(string scrambledWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord
            {
                ScrambledWord = scrambledWord,
                Word = word
            };
            return matchedWord;
        }
    }
}