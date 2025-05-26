namespace L20_Classes.Section;

internal class S05_コンストラクタ
{
  internal void Run()
  {
    Console.WriteLine("\n～～コンストラクタ～～");

    // コンストラクタ
    new ConstructorSample(1);
    new ConstructorSample("2");
    new ConstructorSample();
  }
}

internal class ConstructorSample
{
  public int Id { get; set; }

  // コンストラクタ
  internal ConstructorSample(int id)
  {
    Id = id;
    Console.WriteLine($"コンストラクタ{id}");
  }

  // コンストラクタのオーバーロード
  internal ConstructorSample(string id)
  {
    Console.WriteLine($"コンストラクタ{id} オーバーロード");
  }

  // コンストラクタチェーン：別のコンストラクタに処理を委譲
  internal ConstructorSample() : this(3)
  {
    // 委譲先のコンストラクタが処理された後にこちらが実行される
    Console.WriteLine($"チェーン");
  }
}
