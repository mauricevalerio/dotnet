using System.Text.RegularExpressions;

namespace TextSearchWebAPI.Services
{
    public class TextSearchService : ITextSearchService
    {
        public int Search(string sentence, string text, bool isFullWordSearch, bool isCaseSensitive)
        {

            MatchCollection matches;

            text = Regex.Escape(text);

            if (isFullWordSearch && isCaseSensitive)
            {
                matches = Regex.Matches(sentence, $@"(?<=^|\s){text}(?=\s|$)");
            }
            else if (isFullWordSearch)
            {
                matches = Regex.Matches(sentence, $@"(?<=^|\s){text}(?=\s|$)", RegexOptions.IgnoreCase);
            }
            else if (isCaseSensitive)
            {
                matches = Regex.Matches(sentence, text);
            }
            else
            {
                matches = Regex.Matches(sentence, text, RegexOptions.IgnoreCase);
            }

            return matches.Count;
        }
    }
}
