namespace CSharp.Memo._10_CSharpNote
{
  internal class _10_名前付け
  {

    // 名前付けのガイドライン(MS)
    // https://learn.microsoft.com/ja-jp/dotnet/standard/design-guidelines/naming-guidelines
    // 一般的な名前つけ規則(MS)
    // https://learn.microsoft.com/ja-jp/dotnet/standard/design-guidelines/general-naming-conventions

    // 名前空間
    // 会社名+製品名+プロジェクト名+フォルダ名

    // インターフェース
    // IProduct （頭にI）

    // フィールド
    // Publicなフィールドは基本的にプロパティにすべきなのでフィールドにはしない
    private string _userName; // _camel
    private const int UserIDNumber = 1; // Pascal

    // 列挙体
    private enum ProductMode // Pascal
    {
      Normal,
      Level1,
    }

    // プロパティ
    public string ProductName { get; set; } // Pascal

    // イベント
    public event Action<int> ProductIdChanged; // Pascal

    // メソッド
    public int GetDate() // Pascal
    {
      return 0;
    }

    // パラメーター(userIdのこと)
    public void SetData(int userId, string userName)
    {

    }

    // 二文字の略語は大文字2個（IO）
    // 三文字以上の略語は大文字+小文字（Sql）
    // Id（Identifier）とOk（Okey）は例外


    // 参考
    // C#のコーディングルール：スタイルコップアナライザーを使ってチーム全員が同じコードを書く方法
    // https://yayoi-kkjp.udemy.com/course/cs_coding_rules
  }
}