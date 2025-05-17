namespace L10_Basic.Section;

internal static class S40_繰り返し処理
{
  internal static void Run()
  {
    Console.WriteLine("\n～～繰り返し処理～～");

    // for文
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"for文: {i}");
      if (i == 0)
      {
        Console.WriteLine("for文: continue");
        continue; // 次のループへ
      }
      else if (i == 1)
      {
        Console.WriteLine("for文: break");
        break; // ループを終了
      }
      Console.WriteLine($"for文: iは0でも1でもない");
    }

    // while文
    int j = 0;
    while (j < 2)
    {
      Console.WriteLine($"while文: {j}");
      j++;
    }

    // do-while文
    int k = 0;
    do
    {
      Console.WriteLine($"do-while文: {k}");
      k++;
    } while (k < 2);
  }
}
