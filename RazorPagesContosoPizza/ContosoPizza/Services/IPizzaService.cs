using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public interface IPizzaService
    {
        public IList<Pizza> GetPizzas();
        public void AddPizza(Pizza pizza);
        public void DeletePizza(int id);
    }
}