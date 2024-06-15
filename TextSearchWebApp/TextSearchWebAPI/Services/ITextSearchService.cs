namespace TextSearchWebAPI.Services
{
    public interface ITextSearchService
    {
        public int Search(string sentence, string text, bool isFullWordSearch, bool isCaseSensitive);
    }
}
