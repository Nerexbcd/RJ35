using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RJ35.Models;

namespace RJ35.Controllers;

public class InstallationsController : Controller
{
    private readonly ILogger<InstallationsController> _logger;

    public InstallationsController(ILogger<InstallationsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cable()
    {
        return View();
    }

    public IActionResult Racks()
    {
        return View();
    }

    public IActionResult RackMaterial()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
