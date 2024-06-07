using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;

namespace ContosoPizza.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPizzaService _service;
        public IList<Pizza> PizzaList { get; set; } = default!;

        public IndexModel(IPizzaService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            PizzaList = _service.GetPizzas();
        }
        public IActionResult OnPostDelete(int id)
        {
            _service.DeletePizza(id);

            return RedirectToAction("Get");
        }
    }
}