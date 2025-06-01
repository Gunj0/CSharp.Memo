namespace L20_Class.Section;

internal class S30_継承
{
  internal void Run()
  {
    Console.WriteLine("\n～～継承～～");

    // 基底クラス
    var parent = new SuperClass();
    parent.Method1();

    // 派生クラス
    var child = new SubClass();
    child.Method1();
  }
}

// 基底クラス
internal class SuperClass
{
  // コンストラクタ
  public SuperClass()
  {
  }

  // 仮想メソッド
  public virtual void Method1()
  {
    Console.WriteLine("基底クラス, 仮想メソッド");
  }
}

// 派生クラス
internal class SubClass : SuperClass
{
  // コンストラクタ
  public SubClass() : base()
  {
  }

  // オーバーライド
  public override void Method1()
  {
    Console.WriteLine("派生クラス, オーバーライド");
  }
}
