namespace CSharp.Memo.LambdaSample
{
  internal class AnonymousMethodSample
  {
    // delegate
    delegate bool LenCheck(string value);

    // delegate式を引数として定義したメソッド
    private string[] GetValue(string[] values, LenCheck lencheck)
    {
      var result = new List<string>();
      foreach (var value in values)
      {
        if (lencheck(value))
        {
          result.Add(value);
        }
      }
      return result.ToArray();
    }

    // delegateの引数を直接、匿名メソッドで記載（C#2.0以降）
    public void AnonymousMethod()
    {
      var values = new string[] { "A", "BB", "CCC", "DDDD" };
      var results = GetValue(
        values,
        delegate (string s) { return s.Length == 3; });

      Console.WriteLine("～～AnonymousMethodSample～～");
      foreach (var result in results)
      {
        Console.WriteLine(result);
      }
      Console.WriteLine("");
    }
  }
}
