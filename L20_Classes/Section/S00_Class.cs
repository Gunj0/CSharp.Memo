namespace L20_Classes.Section;

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
