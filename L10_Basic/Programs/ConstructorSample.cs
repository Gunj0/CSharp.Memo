namespace CSharp.Memo.BasicSample
{
  internal class ConstructorSample
  {
    // 通常のコンストラクタ
    internal ConstructorSample(int id, string name, string description)
    {
      Id = id;
      Name = name;
      Description = description;
    }

    // 自身のコンストラクタを継承して引数を減らす
    internal ConstructorSample(int id, string name) : this(id, name, "サンプル")
    {
      // 継承元が処理されてからこちらを処理する
      Name += "さん";
    }

    internal int Id { get; set; }
    internal string Name { get; set; }
    internal string Description { get; set; }

    internal void Call()
    {
      Console.WriteLine("～～ConstructorSample～～");
      Console.WriteLine($"{Id}: {Name}: {Description}");
      Console.WriteLine("");
    }
  }
}
