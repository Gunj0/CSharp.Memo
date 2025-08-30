using Microsoft.AspNetCore.Mvc;

namespace L70_Mvc.Controllers;

/// <summary>
/// コントローラのアクションサンプル
/// </summary>
public class SampleController : Controller
{
  /// <summary>
  /// Content (~/Sample)
  /// </summary>
  /// <returns>テキスト</returns>
  public IActionResult Index()
  {
    return Content("Hello from MVC!");
  }

  /// <summary>
  /// View (~/Sample/ViewSample)
  /// </summary>
  /// <returns>./Views/ViewSample/Index.html</returns>
  public IActionResult ViewSample()
  {
    // ビュー変数の設定
    ViewBag.Message = "ViewBag Sample";
    // ビューの返却
    return View();
    // Common.cshtmlを返す場合
    // return View("Common");
    // ./Views/Hello/Common.cshtmlを返す場合
    // return View("Common", "Hello");
  }

  /// <summary>
  /// File (~/Sample/FileSample)
  /// </summary>
  /// <returns>ファイル</returns>
  public IActionResult FileSample()
  {
    return File("", "");
  }

  /// <summary>
  /// Redirect (~/Sample/RedirectSample)
  /// </summary>
  /// <returns>リダイレクト</returns>
  public IActionResult RedirectSample()
  {
    return RedirectToAction("Index");
  }

  /// <summary>
  /// NotFound (~/Sample/NotFoundSample)
  /// </summary>
  /// <returns>NouFound</returns>
  public IActionResult NotFoundSample()
  {
    return NotFound();
  }
}
