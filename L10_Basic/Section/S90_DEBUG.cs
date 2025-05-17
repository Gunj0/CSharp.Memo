namespace L10_Basic.Section;

internal static class S90_デバッグ
{
  internal static void Run()
  {
    Console.WriteLine("～～デバッグ～～");

    // 条件付きコンパイル
    // DEBUGが定義されているときだけ実行
#if DEBUG
    int i = 1;
    Console.WriteLine($"#if DEBUG: {i}");
#endif

    // DEBUGが定義されていないときだけ実行
#if !DEBUG
    int j = 2;
    Console.WriteLine($"#if !DEBUG: {j}");
#endif
  }
}
