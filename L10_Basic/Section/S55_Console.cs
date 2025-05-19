using System.ComponentModel;
using System.Text;

namespace L10_Basic.Section;

internal static class S55_Console
{
  internal static void Run()
  {
    Console.WriteLine("\n～～入出力～～");

    // コンソール入力
    Console.Write("名前を入力してください: ");
    // var inputName = Console.ReadLine();

    // コンソール出力
    Console.WriteLine($"Console.ReadLine, Console.WriteLine");
    // コンソール出力（埋め込み）
    var name = "Taro";
    Console.WriteLine("Hello World {0}", name);

  }
}
