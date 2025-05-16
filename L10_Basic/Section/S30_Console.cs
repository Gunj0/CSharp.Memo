namespace L10_Basic.Section;

internal class S03_Console
{
  internal static void Run()
  {
    Console.WriteLine("\n～～L10-S03 Console～～");

    // コンソールに文字列を出力
    var name = "Taro";
    Console.WriteLine($"Hello World {name}");

    // コンソールに文字列を出力（埋め込み）
    Console.WriteLine("Hello World {0}", name);

    // 文字列入力
    Console.Write("名前を入力してください: ");
    var inputName = Console.ReadLine();
    Console.WriteLine($"こんにちは、{inputName}さん");
  }
}
