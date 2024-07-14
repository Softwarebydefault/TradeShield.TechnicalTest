using System.Linq;

namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        var wordCount = 0;

        //split string sentences based on dot

        var sentences = s.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        for (int i = 0; i < sentences.Length; i++)
        {
            //Strip each sentence of punctuation marks

            sentences[i] = sentences[i].Replace("?", String.Empty).Replace("!", String.Empty);

            //split each sentence by spaces to get word count

            var words = sentences[i].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            //Determine sentence with highest word count

            wordCount = Math.Max(wordCount, words.Length);
        }

        return wordCount;
    }
}
