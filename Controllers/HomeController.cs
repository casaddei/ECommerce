using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;

namespace ECommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult Accedi ()
    {
        return View();
    }
     public IActionResult Logout ()
    {
        return View();
    }
    [HttpPost]
    public IActionResult P1(Utente u)
    {
        Database db = new();
        if (u.User != null)
        {
            HttpContext.Session.SetString("Accedi", u.User);
        }
        string? Accedi = HttpContext.Session.GetString("Accedi");
        foreach (var item in db.Utenti)
        {
            if (item.User == u.User && item.Password == u.Password)
            {
                return View("AreaRiservata");
            }
        }
        return View("Errore");
    }
    [HttpPost]
    public IActionResult P2()
    {
        HttpContext.Session.Clear();
        return View("Accedi");
    }
     public IActionResult Registrati ()
    {
        return View();
    }
      public IActionResult Registrato (Utente u)
    {
        Database db = new Database ();
        db.Utenti.Add(u);
        db.SaveChanges();
        return View(u);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
     public IActionResult Eventi()
    {
        Database db = new Database();
        return View(db.Eventi);
    }
   
   
}
