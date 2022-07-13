using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ShoppingListController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public ShoppingListController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    /*test for changes, and check for changes again, push repo*/
    [HttpGet(Name = "GetShoppingList")]
    public ShoppingListItem[] Get()
    {
        var items = new ShoppingListItem[] {
            new ShoppingListItem()
            {
                Title = "Milk"
            },
            new ShoppingListItem()
            {
                Title = "Eggs"
            },
            new ShoppingListItem()
            {
                Title = "Stick of Butter"
            }
        };
        return items;
    }
}
