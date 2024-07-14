using System.Linq;

namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        var wordCount = 0;

        //split string sentences based on dot

        var sentences = s.Split('.', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < sentences.Length; i++)
        {
            //Strip each sentence of punctuation marks

            sentences[i] = sentences[i].Replace("?", String.Empty).Replace("!", String.Empty);

            //split each sentence by spaces to get word count

            var words = sentences[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Determine sentence with highest word count

            wordCount = Math.Max(wordCount, words.Length);
        }

        return wordCount;
    }
}

public class Sentence
{
    public string FullText { get; set; }
    public int WordCount { get; set; }
}
