namespace CSharp.Memo.Sample
{
  internal static class CheckSample
  {
    /// <summary>
    /// 入力チェック
    /// </summary>
    internal static void Check()
    {
      // 含むかチェック
      var containCheck = "containCheck";
      if (containCheck.Contains('e'))
      {
        Console.WriteLine("eが入ってる！");
      }

      // 空白チェック
      var blankCheck = "blankCheck";
      if (blankCheck.Trim().Length == 0)
      {
        Console.WriteLine("何も入ってない！");
      }
    }
  }
}
