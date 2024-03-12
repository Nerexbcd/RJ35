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

namespace RJ35.Controllers;

public class CartController : Controller
{
    private readonly RJ35Context _context;

    public CartController(RJ35Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AddToCart()
    {
        return View();
    }


}
