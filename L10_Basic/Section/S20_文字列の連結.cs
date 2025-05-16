namespace L10_Basic.Section;

internal static class S20_文字列の連結
{
  internal static void Run()
  {
    Console.WriteLine("\n～～L10-S20 文字列の連結～～");

    // 文字列の連結
    var s1 = "Hello";
    var s2 = "World";
    var s3 = s1 + " " + s2;
    Console.WriteLine($"文字列の連結: {s3}");

    // String.Format
    string s4 = String.Format("{0} {1}", s1, s2);
    Console.WriteLine($"String.Format: {s4}");

    // 挿入文字列
    string s5 = $"Hello {s2}";
    Console.WriteLine($"挿入文字列: {s5}");
  }
}
