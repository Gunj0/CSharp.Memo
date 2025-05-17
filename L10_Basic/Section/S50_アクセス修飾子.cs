namespace L10_Basic.Section;

internal class S50_アクセス修飾子
{
  // public
  public string? PublicName { get; set; }

  // internal: 同じプロジェクト(アセンブリ)内のみ
  internal string? InternalName { get; set; }

  // protected: 同じクラス内と派生クラス内のみ
  protected string? ProtectedName { get; set; }

  // private: 同じクラス内のみ
  private string? PrivateName { get; set; }

  internal void Run()
  {
    Console.WriteLine("\n～～アクセス修飾子～～");

    PublicName = "public";
    InternalName = "internal";
    ProtectedName = "protected";
    PrivateName = "private";

    Console.WriteLine($"{PublicName}, {InternalName}, {ProtectedName}, {PrivateName}");
  }
}
