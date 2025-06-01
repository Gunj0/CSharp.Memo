namespace L20_Class.Section;

internal class S25_列挙型
{
  internal void Run()
  {
    Console.WriteLine("\n～～列挙型～～");

    // 列挙型
    Console.WriteLine($"列挙型: {EnumSampleType.Enum1}");
    Console.WriteLine($"DayOfWeek: {DayOfWeek.Monday}");
  }
}

// enum(実体は0から始まるint)
enum EnumSampleType
{
  Enum1,
  Enum2,
}
