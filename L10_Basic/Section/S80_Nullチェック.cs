namespace L10_Basic.Section;

internal static class S80_Nullチェック
{
  internal static void Run()
  {
    Console.WriteLine("\n～～Nullチェック～～");

    // nullチェック
    string? nullable = null;
    if (nullable == null)
    {
      Console.WriteLine("nullチェック1: ==");
    }

    // null許容型の型変換
    int? nullableInt = 10;
    if (nullableInt.HasValue)
    {
      Console.WriteLine("nullチェック2: HasValue");
      int notNull = nullableInt.Value;
      Console.WriteLine($"null許容型の型変換: {notNull}");
    }
  }
}
