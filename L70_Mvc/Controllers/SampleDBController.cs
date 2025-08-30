using Microsoft.AspNetCore.Mvc;
using L70_Mvc.Models.Database;

namespace L70_Mvc.Controllers;

/// <summary>
/// SampleDBController
/// </summary>
/// <param name="dbContext"></param>
public class SampleDBController(SampleDbContext dbContext) : Controller
{
  /// <summary>
  /// DBコンテキスト
  /// </summary>
  private readonly SampleDbContext _dbContext = dbContext;

  /// <summary>
  /// Book一覧表示
  /// </summary>
  /// <returns>View</returns>
  public IActionResult Index()
  {
    var books = _dbContext.Books;
    return View(books);
  }
}
