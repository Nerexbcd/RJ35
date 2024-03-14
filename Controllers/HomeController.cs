using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RJ35.Data;
using RJ35.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace RJ35.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{
    private readonly RJ35Context _context;

    public HomeController(RJ35Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
