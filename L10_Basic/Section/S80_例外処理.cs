namespace L10_Basic.Section;

internal static class S80_例外処理
{
  internal static void Run()
  {
    Console.WriteLine("\n～～例外処理～～");

    // 例外処理
    try
    {
      var num = 10;
      var result = num / 0; // ゼロ除算
      Console.WriteLine($"result: {result}");
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine($"catch: ゼロ除算エラー: {ex.Message}");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"catch: それ以外のエラー: {ex.Message}");
    }
    finally
    {
      Console.WriteLine("finally: 処理終了");
    }
  }
}
