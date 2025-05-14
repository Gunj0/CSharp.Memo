namespace CSharp.Memo.AdvancedSample
{
  internal class ExceptionSample
  {
    public ExceptionSample()
    {
      var list = new List<int>();
      try
      {
        Console.WriteLine("～～ExceptionSample～～");
        var hoge = list[0];
      }
      catch (ArgumentNullException e)
      {
        Console.WriteLine($"1: {e}");
      }
      catch (Exception e)
      {
        throw new CsvReadException(e);
      }
      finally
      {

      }
    }
  }

  // 独自例外
  public sealed class CsvReadException : Exception
  {
    public CsvReadException(Exception e) : base("読み込み失敗")
    {
      Console.WriteLine(e);
      Console.WriteLine("");
    }

  }
}
