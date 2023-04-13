using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projet_Here.Models;

namespace Projet_Here.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // public List<User> GetUsers()
    // {
    //     List<User> users = new List<User>();
    //     users = _context.Users;
    //     return users;
    // }

    //     public static List<User> GetUsers()
    // {
    //     // Get users
    //     List<User> users = new List<User>(); 
    //     users = UserApiController.GetUsers();

    //     return users;
    // }
}
