using TextSearchWebAPI.Model;

namespace TextSearchWebAPI.Services
{
    public interface ITextSearchService
    {
        public int Search(TextSearch textSearch);
    }
}
