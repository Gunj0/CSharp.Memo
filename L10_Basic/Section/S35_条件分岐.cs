namespace L10_Basic.Section;

internal static class S35_条件分岐
{
  internal static void Run()
  {
    Console.WriteLine("\n～～条件分岐～～");

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
      case 1:
        Console.WriteLine($"switch: {num}は1です");
        break;
      case 2:
        Console.WriteLine($"switch: {num}は2です");
        break;
      default:
        Console.WriteLine($"switch: {num}は1でも2でもありません");
        break;
    }
  }
}
