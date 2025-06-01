namespace L20_Class.Section;

internal class S20_構造体
{
  internal void Run()
  {
    Console.WriteLine("\n～～構造体～～");

    // 構造体
    // DateTimeやTimeSpanなどは構造体
    var structSample = new StructSample();
    structSample.Title = "プロパティ";
    Console.WriteLine(structSample.Title);
    structSample.Show();
  }
}

internal struct StructSample
{
  // コンストラクタ
  public StructSample()
  {
    Console.WriteLine("コンストラクタ");
    Console.WriteLine(_field);
  }

  // フィールド
  private string _field = "フィールド";

  // プロパティ
  public string? Title { get; set; }

  // メソッド
  public void Show()
  {
    Console.WriteLine("メソッド");
  }
}
