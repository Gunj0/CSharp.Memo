namespace L10_Basic.Section;

internal class S00_Class
{
  // プロパティ
  public string Name { get; set; }

  // メソッド
  internal static void Run()
  {
    Console.WriteLine("\n～～Class～～");

    Console.WriteLine($"{nameof(S00_Class)}.Run()");
  }
}
