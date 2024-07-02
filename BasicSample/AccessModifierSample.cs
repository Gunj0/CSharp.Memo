namespace CSharp.Memo.BasicSample
{
  public class AccessModifierSample
  {
    // どこからでもアクセス可
    public void PublicCall()
    {
      Console.WriteLine("～～AccessModifierSample～～");
      Console.WriteLine("Publicメソッド");
      Console.WriteLine("");
    }

    // 同一アセンブリ（exe, dll）からアクセス可
    internal int Num { get; set; }

    // クラス内部とその派生クラスからアクセス可
    protected string? Name { get; set; }

    // internal + protectedの両方の範囲
    internal protected decimal? Value { get; set; }

    // クラス内部のみ
    private double Temperature { get; set; }
  }
}
