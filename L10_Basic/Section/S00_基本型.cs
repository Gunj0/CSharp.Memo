namespace L10_Basic.Section;

internal static class S00_基本型
{
  internal static void Run()
  {
    Console.WriteLine("\n～～基本型～～");

    // 整数型
    int i1 = 1;
    // アンダースコアは無視されるため、見やすくするのに使う
    int i2 = 1_000;
    // 16進数
    int i3 = 0xFF;
    // 2進数
    int i4 = 0b1111_1111;
    Console.WriteLine($"整数型:{i1}, アンダースコアあり:{i2}, 16進数:{i3}, 2進数:{i4}");

    // 浮動小数点型
    double d1 = 1.2;
    // アンダースコアは無視されるため、見やすくするのに使う
    double d2 = 1_000.2;
    // 指数
    double d3 = 1.0e-6;
    Console.WriteLine($"浮動小数点型:{d1}, アンダースコアあり:{d2}, 指数:{d3}");

    // 高精度
    decimal d4 = 2.3m;
    Console.WriteLine($"高精度:{d4}");

    // 文字型(シングルクォーテーション)
    char c = 'A';
    Console.WriteLine($"文字型:{c}");

    // 文字列型(ダブルクォーテーション)
    string s1 = "Taro";
    // 逐語的文字列
    string s2 = @"Hello
World";
    // エスケープ
    string s3 = $"Hello \"HERE\" ";
    Console.WriteLine($"文字列型:{s1}, 逐語的文字列:{s2}, エスケープ:{s3}");

    // 論理型
    bool b = true;
    Console.WriteLine($"論理型:{b}");
  }
}
