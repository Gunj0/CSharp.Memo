namespace CSharp.Memo.BasicSample
{
  internal static class InputCheckSample
  {
    /// <summary>
    /// 入力チェック
    /// </summary>
    internal static void InputCheck()
    {
      Console.WriteLine("～～InputCheckSample～～");

      // 含むかチェック
      var containCheck = "containCheck";
      if (containCheck.Contains('e'))
      {
        Console.WriteLine($"{containCheck}: eが入ってる！");
      }

      // 空白チェック
      var blankCheck = " ";
      if (blankCheck.Trim().Length < 1)
      {
        Console.WriteLine($"{blankCheck}: 何も入ってない！");
      }

      Console.WriteLine("");
    }
  }
}
