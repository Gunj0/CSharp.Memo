namespace L10_Basic.Section;

internal static class S20_その他の組み込み型
{
  internal static void Run()
  {
    Console.WriteLine("\n～～その他の組み込み型～～");

    // オブジェクト: 全ての基底の型
    object obj = 1;
    Console.WriteLine($"オブジェクト: {obj}");

    // 日時型
    DateTime dt = DateTime.Now;
    Console.WriteLine($"日時型: {dt}");
  }
}
