namespace CSharp.Memo.LambdaSample
{
  internal class PredicateSample
  {
    // Predicate（戻り値がboolで用意されているDelegate）
    private string[] GetValue(
      string[] values,
      Predicate<string> predicate)
    {
      var result = new List<string>();
      foreach (var value in values)
      {
        if (predicate(value))
        {
          result.Add(value);
        }
      }
      return result.ToArray();
    }

    public void Predicates()
    {
      var values = new string[] { "A", "BB", "CCC", "DDDD" };
      var results = GetValue(
        values,
        delegate (string s) { return s.Length == 4; });

      Console.WriteLine("～～PredicateSample～～");
      foreach (var result in results)
      {
        Console.WriteLine(result);
      }
      Console.WriteLine("");
    }
  }
}