namespace L20_Classes.Section;

internal class S30_継承
{
  internal void Run()
  {
    Console.WriteLine("\n～～継承～～");

    // 継承

    // 基底クラス
    var parent = new ParentClass();
    parent.Method1();

    // サブクラス
    var child = new ChildClass();
    child.Method1();
  }
}

// 基底クラス, スーパークラス
internal class ParentClass
{
  // 仮想メソッド
  public virtual void Method1()
  {
    Console.WriteLine("基底クラス");
  }
}

// 派生クラス, サブクラス
internal class ChildClass : ParentClass
{
  // オーバーライド
  public override void Method1()
  {
    Console.WriteLine("派生クラス, オーバーライド");
  }
}
