namespace L10_Basic.Section;

internal static class S05_文字列
{
  internal static void Run()
  {
    Console.WriteLine("\n～～文字列～～");

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

    // Length
    var length = "Hello".Length;
    Console.WriteLine($"Length: {length}");

    // SubString(開始位置, 文字数)
    var s6 = "Hello World";
    var s7 = s6.Substring(1, 5);
    Console.WriteLine($"SubString: {s7}");

    // Trim
    var s8 = "  Hello World  ";
    var s9 = s8.Trim();
    Console.WriteLine($"Trim: {s9}");

    // ToUpper, ToLower
    var s10 = "Hello World";
    var s11 = s10.ToUpper();
    var s12 = s10.ToLower();
    Console.WriteLine($"ToUpper: {s11}, ToLower: {s12}");

    // Replace
    var s13 = "Hello World";
    var s14 = s13.Replace("World", "C#");
    Console.WriteLine($"Replace: {s14}");

    // Contains
    var s15 = "Hello World";
    var s16 = s15.Contains("World");
    Console.WriteLine($"Contains: {s16}");

    // Split
    var s17 = "Hello,World,C#";
    var s18 = s17.Split(',');
    Console.WriteLine($"Split: {s18[0]}, {s18[1]}, {s18[2]}");
  }
}
