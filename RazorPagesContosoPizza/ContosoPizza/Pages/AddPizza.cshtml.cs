using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Pages
{
    public class AddPizzaModel : PageModel
    {
        private readonly IPizzaService _service;
        [BindProperty]
        public Pizza NewPizza { get; set; } = default!;

        public AddPizzaModel(IPizzaService service)
        {
            _service = service;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewPizza == null)
            {
                return Page();
            }

            _service.AddPizza(NewPizza);

            return RedirectToPage("Index");
        }

    }
}
