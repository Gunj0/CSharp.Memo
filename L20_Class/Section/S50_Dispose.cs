namespace L20_Class.Section;

internal class S50_Dispose
{
  internal void Run()
  {
    Console.WriteLine("\n～～Dispose～～");

    // Dispose
    var file = new StreamWriter("IOSample.txt");
    try
    {
      // ファイルの読み込み処理
    }
    catch (Exception)
    {
      // 例外処理
    }
    finally
    {
      // Disposeでリソースを解放
      file.Dispose();
      Console.WriteLine("Disposeメソッド");
    }

    // usingを使う書き方
    using var file2 = new StreamReader("IOSample.txt");
    file2.GetType();
    Console.WriteLine("usingで自動Dispose");

    // IDisposable
    var disposeClass = new DisposeClass();
    disposeClass.Dispose();
  }
}

internal class DisposeClass : IDisposable
{
  // IDisposableインターフェースを実装することでDispose実装を強制
  public void Dispose()
  {
    Console.WriteLine("IDisposable");
  }
}
