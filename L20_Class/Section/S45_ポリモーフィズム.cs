namespace L20_Class.Section;

internal class S45_ポリモーフィズム
{
  internal void Run()
  {
    Console.WriteLine("\n～～ポリモーフィズム～～");

    var pol = new List<IPolymorphic>
    {
      new SubClass1(),
      new SubClass2()
    };

    // ポリモーフィズム
    foreach (var item in pol)
    {
      item.Method1();
    }
  }
}

// インターフェース
internal interface IPolymorphic
{
  void Method1();
}

// 実装クラス1
internal class SubClass1 : IPolymorphic
{
  public void Method1()
  {
    Console.WriteLine("ポリモーフィズム1");
  }
}

// 実装クラス2
internal class SubClass2 : IPolymorphic
{
  // オーバーライド
  public void Method1()
  {
    Console.WriteLine("ポリモーフィズム2");
  }
}
