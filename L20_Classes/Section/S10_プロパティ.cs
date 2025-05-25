namespace L20_Classes.Section;

internal class S10_プロパティ
{
  internal void Run()
  {
    Console.WriteLine("\n～～プロパティ～～");

    // プロパティ
    var propertySample = new PropertySample();
    Console.WriteLine(propertySample.Property1);
    Console.WriteLine(propertySample.Property2);
    Console.WriteLine(propertySample.Property3);
    Console.WriteLine(propertySample.Property4);
  }
}

internal class PropertySample
{
  // プロパティ(自動実装プロパティ)
  public string Property1 { get; set; } = "プロパティ";
  // 読み取り専用
  public string Property2 { get; } = "読み取り専用プロパティ";
  // クラス内のみセット可能
  public string Property3 { get; private set; } = "クラス内のみセット可能プロパティ";
  // 条件付きプロパティ
  private string _property = "条件付きプロパティ";
  public string Property4
  {
    // getアクセサー
    get
    {
      return _property + "です";
    }
    // setアクセサー
    set
    {
      // valueはプロパティにセットされた値
      if (value == "条件付きプロパティ")
      {
        _property = value;
      }
      else
      {
        _property = "条件付きプロパティじゃない";
      }
    }
  }
}
