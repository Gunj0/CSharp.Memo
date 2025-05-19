namespace L10_Basic.Section;

internal static class S75_入力チェック
{
  internal static void Run()
  {
    Console.WriteLine("\n～～入力チェック～～");

    // 含むかチェック
    var containCheck = "containCheck";
    if (containCheck.Contains('e'))
    {
      Console.WriteLine($"Contains: {containCheck}");
    }

    // 空白チェック
    var blankCheck = " ";
    if (blankCheck.Trim().Length < 1)
    {
      Console.WriteLine($"空白チェック: {blankCheck}");
    }
  }
}
