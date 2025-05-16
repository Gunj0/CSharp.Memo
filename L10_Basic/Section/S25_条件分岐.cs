namespace L10_Basic.Section;

internal static class S25_条件分岐
{
  internal static void Run()
  {
    Console.WriteLine("\n～～L10-S25 条件分岐～～");

    // if文
    var num = 10;
    if (num > 0)
    {
      Console.WriteLine($"if: {num}は正の数です");
    }
    else if (num < 0)
    {
      Console.WriteLine($"if: {num}は負の数です");
    }
    else
    {
      Console.WriteLine($"if: {num}はゼロです");
    }

    // switch文
    switch (num)
    {
      case > 0:
        Console.WriteLine($"switch: {num}は正の数です");
        break;
      case < 0:
        Console.WriteLine($"switch: {num}は負の数です");
        break;
      default:
        Console.WriteLine($"switch: {num}はゼロです");
        break;
    }
  }
}
