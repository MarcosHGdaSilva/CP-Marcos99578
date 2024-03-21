using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class ContatoController : Controller
{
    private readonly ILogger<ContatoController> _logger;

    public ContatoController(ILogger<ContatoController> logger)
    {
        _logger = logger;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }
}