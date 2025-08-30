using System.Diagnostics;
using L70_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace L70_Mvc.Controllers;

/// <summary>
/// HomeController
/// </summary>
/// <param name="logger">ロガー</param>
public class HomeController(ILogger<HomeController> logger) : Controller
{
    /// <summary>
    /// ロガー
    /// </summary>
    private readonly ILogger<HomeController> _logger = logger;

    /// <summary>
    /// Index
    /// </summary>
    /// <returns>View</returns>
    public IActionResult Index()
    {
        _logger.LogInformation("Index action called.");
        return View();
    }

    /// <summary>
    /// TODO: なに？
    /// </summary>
    /// <returns></returns>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
