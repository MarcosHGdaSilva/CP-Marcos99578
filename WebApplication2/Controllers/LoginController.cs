using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }
}