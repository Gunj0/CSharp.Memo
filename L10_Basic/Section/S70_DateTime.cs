namespace L10_Basic.Section;

internal static class S70_DateTime
{
  internal static void Run()
  {
    Console.WriteLine("\n～～DateTime～～");

    // 日時型
    DateTime dt = DateTime.Now;
    Console.WriteLine($"日時型: {dt}");

    // 日時型のプロパティ
    Console.WriteLine($"年: {dt.Year}");
    Console.WriteLine($"月: {dt.Month}");
    Console.WriteLine($"日: {dt.Day}");
    Console.WriteLine($"時: {dt.Hour}");
    Console.WriteLine($"分: {dt.Minute}");
    Console.WriteLine($"秒: {dt.Second}");

    // Today
    var today = DateTime.Today;
    Console.WriteLine($"Today: {today}");

    // 日時型のメソッド
    var dt2 = dt.AddDays(1);
    Console.WriteLine($"1日後: {dt2}");

    // ToString
    var dt3 = dt.ToString("yyyy/MM/dd");
    Console.WriteLine($"ToString: {dt3}");
  }
}
