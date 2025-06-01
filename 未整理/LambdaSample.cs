namespace CSharp.Memo.LambdaSample
{
  internal class LambdaSample
  {
    // ラムダ式を受け取る方
    private string[] Test(string[] values, Predicate<string> predicate)
    {
      var results = new List<string>();
      foreach (var value in values)
      {
        if (predicate(value))
        {
          results.Add(value);
        }
      }
      return results.ToArray();
    }

    public void Lambdas()
    {
      var values = new string[] { "A", "BB", "CCC" };

      // ラムダ式
      var results = Test(values, x => x.Length == 2);

      Console.WriteLine("～～LambdaSample～～");
      foreach (var result in results)
      {
        Console.WriteLine(result);
      }
      Console.WriteLine("");
    }
  }
}
