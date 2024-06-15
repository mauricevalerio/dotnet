using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TextSearchWebAPI.Services;

namespace TextSearchWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextSearchController : ControllerBase
    {
        private readonly ITextSearchService _textSearchService;
        public TextSearchController(ITextSearchService textSearchService)
        {
            _textSearchService = textSearchService;
        }

        [HttpGet]
        public ActionResult<int> Get(string sentence, string text, bool isFullWordSearch, bool isCaseSensitive)
        {
            if (String.IsNullOrEmpty(sentence) || String.IsNullOrEmpty(text))
            {
                return BadRequest();
            }
            return Ok(_textSearchService.Search(sentence, text, isFullWordSearch, isCaseSensitive));
        }
    }
}
