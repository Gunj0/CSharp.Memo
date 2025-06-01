namespace L20_Class.Section;

internal class S35_抽象クラス
{
  internal void Run()
  {
    Console.WriteLine("\n～～抽象クラス～～");

    // 抽象クラスを継承した具象クラス
    var concreteClass = new ConcreteClass();
    concreteClass.Method1();
    concreteClass.Method2();
  }
}

// 抽象クラス(インスタンス化不可)
internal abstract class AbstractClass
{
  // 抽象メソッド(派生クラスで override を強制)
  internal abstract void Method1();

  // 通常メソッドも定義可
  internal void Method2()
  {
    Console.WriteLine("抽象クラスの通常メソッド");
  }
}

internal class ConcreteClass : AbstractClass
{
  internal override void Method1()
  {
    Console.WriteLine("抽象クラスの抽象メソッド");
  }
}
