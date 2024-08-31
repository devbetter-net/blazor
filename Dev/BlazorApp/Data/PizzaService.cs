using BlazorApp.Models;

namespace BlazorApp.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        return Task.FromResult(new Pizza[0]);
    }
}
