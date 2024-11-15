using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TextSearchWebAPI.Services;
using TextSearchWebAPI.Model;

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

        [HttpPost]
        public ActionResult<int> Post(TextSearch textSearch)
        {
            if (String.IsNullOrEmpty(textSearch.Sentence) || String.IsNullOrEmpty(textSearch.Text))
            {
                return BadRequest();
            }
            return Ok(_textSearchService.Search(textSearch));
        }
    }
}
