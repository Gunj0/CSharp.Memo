namespace L20_Class.Section;

internal class S40_インターフェース
{
  internal void Run()
  {
    Console.WriteLine("\n～～インターフェース～～");

    // インターフェースを実装したクラス
    var interfaceClass = new InterfaceClass();
    interfaceClass.Method1();
  }
}

// インターフェース
// 抽象クラスと同様にインスタンス化不可
// シグネチャのみを定義し、実装は派生クラスで行う
internal interface IInterface
{
  void Method1();
}

// 実装クラス
internal class InterfaceClass : IInterface
{
  public void Method1()
  {
    Console.WriteLine("インターフェイス");
  }
}
