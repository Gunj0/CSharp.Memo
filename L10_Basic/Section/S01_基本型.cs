namespace L10_Basic.Section;

internal static class S01_基本型
{
  internal static void Run()
  {
    Console.WriteLine("～～L10-S01 基本型～～");

    // 整数
    int i1 = 1;
    // アンダースコアは無視される
    int i2 = 1_000;
    // 16進数
    int i3 = 0xFF;
    // 2進数
    int i4 = 0b1111_1111;
    Console.WriteLine($"整数型:{i1}, アンダースコアあり:{i2}, 16進数:{i3}, 2進数:{i4}");

    // 浮動小数点数
    double d1 = 1.2;
    // アンダースコアは無視される
    double d2 = 1_000.2;
    // 指数
    double d3 = 1.0e-6;
    // 高精度
    decimal d4 = 2.3m;
    Console.WriteLine($"浮動小数点:{d1}, アンダースコア:{d2}, 指数:{d3}, 高精度:{d4}");

    // 文字型
    char c = 'A';
    // 文字列型
    string s1 = "Taro";
    // 逐語的文字列
    string s2 = @"Hello
World";
    // 文字列補間
    string s3 = $"Hello {s1}";
    Console.WriteLine($"文字:{c}, 文字列:{s1}, 逐語的文字列:{s2}, 文字列補間:{s3}");

    // 論理型
    bool b = true;
    Console.WriteLine($"論理型:{b}");

    // 日付型
    DateTime f = DateTime.Now;
    Console.WriteLine($"日付型:{f}");

    // 6. 配列型
    int[] g = new int[5];
    Console.WriteLine($"日付型:{f}");
  }
}
