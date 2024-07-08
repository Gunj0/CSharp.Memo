namespace CSharp.Memo.LambdaSample
{
  internal class DelegateSample
  {
    // delegate（委譲）
    // メソッドの引数と戻り値の型を定義する
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

    // delegate式の実装
    private bool LengthCheck(string value)
    {
      return value.Length == 1;
    }

    public void Delegates()
    {
      var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };

      // delegate式を使ったメソッドの使用
      var results = GetValue(values, LengthCheck);

      Console.WriteLine("～～DelegateSample～～");
      foreach (var result in results)
      {
        Console.WriteLine($"{result}");
      }
      Console.WriteLine("");
    }
  }
}
