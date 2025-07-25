
using System.Diagnostics;
using en_passant.Models;
using en_passant.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace en_passant.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStockService _stockService;

    public HomeController(ILogger<HomeController> logger, IStockService stockService)
    {
        _logger = logger;
        _stockService = stockService;
    }

    public IActionResult Index()
    {
        return View(_stockService);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        throw new Exception();
        //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}