namespace L20_Classes.Section;

internal class S00_クラス
{
  internal void Run()
  {
    Console.WriteLine("\n～～クラス～～");

    // クラス
    var book = new Book();
    book.Title = "プロパティ";
    Console.WriteLine(book.Title);
    book.Show();
  }
}

internal class Book
{
  // コンストラクタ
  public Book()
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
