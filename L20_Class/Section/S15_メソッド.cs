namespace L20_Class.Section;

internal class S15_メソッド
{
  internal void Run()
  {
    Console.WriteLine("\n～～メソッド～～");

    // メソッドの呼び出し
    var methodSample = new MethodSample();
    methodSample.Show();
    methodSample.Show("オーバーロード");
  }
}

internal class MethodSample
{
  // メソッド
  public void Show()
  {
    Console.WriteLine("メソッド");
  }

  // メソッドのオーバーロード
  public void Show(string title)
  {
    Console.WriteLine($"メソッド {title}");
  }
}
