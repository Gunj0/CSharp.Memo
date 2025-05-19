namespace L20_Classes.Section;

internal class S00_Class
{
  internal void Run()
  {
    Console.WriteLine("\n～～Class～～");

    // クラス
    var book = new Book();
    book.Title = "C#入門";
    Console.WriteLine($"プロパティ: {book.Title}");
    book.Show();
  }
}

internal class Book
{
  // プロパティ
  public string Title { get; set; } = "タイトル未設定";

  // メソッド
  public void Show()
  {
    Console.WriteLine($"メソッド: {Title}");
  }

  // オーバーロード
  public void Show(string title)
  {
    Console.WriteLine($"メソッド: {title}");
  }
}
