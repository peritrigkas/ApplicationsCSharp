using System;
using System.Collections.Generic;

namespace WordScrambler
{
     class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach(var scrambleddWord in scrambledWords)
            {
                foreach(var word in wordList)
                {
                    if(scrambleddWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add();
                    }
                }
            }

            return matchedWords;
        }
    }
}