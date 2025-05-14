namespace CSharp.Memo.LambdaSample
{
  internal class FuncActionSample
  {
    // Func<string, int, bool>（引数0～＋戻り値のDelegate）
    private string[] FuncSample(string[] values, Func<string, bool> func)
    {
      var results = new List<string>();
      foreach (var value in values)
      {
        if (func(value))
        {
          results.Add(value);
        }
      }
      return results.ToArray();
    }

    // Action<string>（引数0～のDelegate。戻り値なし）
    private void ActionSample(Action<int> action)
    {
      Console.WriteLine("～～FuncActionSample～～");
      action(10);
    }

    public void FuncActions()
    {
      var values = new string[] { "A", "BB", "CCC" };

      // Func
      var result1 = FuncSample(values, x => x.Length == 2);
      // Action
      ActionSample(num => Console.WriteLine(num));

      foreach (var result in result1)
      {
        Console.WriteLine(result);
      }
      Console.WriteLine();
    }
  }
}
