using Microsoft.AspNetCore.Mvc;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Greet(string name)
    {
        return Content($"Привет, {name}!");
    }

    public IActionResult UserInfo()
    {
        var user = new User { Name = "Иван Иванов", Age = 30 };
        return View(user);
    }
}