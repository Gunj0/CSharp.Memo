namespace L10_Basic.Section;

internal static class S10_型変換
{
  internal static void Run()
  {
    Console.WriteLine("\n～～型変換～～");

    // 型キャスト
    double d = 1.2;
    int i = (int)d;
    Console.WriteLine($"キャスト: {i}");

    // Parse
    string s1 = "1";
    int i1 = int.Parse(s1);
    Console.WriteLine($"Parse: {i1}");

    // TryPase
    string s2 = "2";
    if (int.TryParse(s2, out int i2))
    {
      Console.WriteLine($"TryParse: {i2}");
    }

    // Convert
    string s3 = "3";
    int i3 = Convert.ToInt32(s3);
    Console.WriteLine($"Convert: {i3}");
  }
}
