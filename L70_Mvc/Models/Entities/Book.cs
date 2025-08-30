namespace L70_Mvc.Models.Entities;

public class Book
{
  /// <summary>
  /// BookId
  /// </summary>
  public int BookId { get; set; }

  /// <summary>
  /// ISBN
  /// </summary>
  public string Isbn { get; set; } = string.Empty;

  /// <summary>
  /// タイトル
  /// </summary>
  public string Title { get; set; } = string.Empty;

  /// <summary>
  /// 価格
  /// </summary>
  public int Price { get; set; }

  /// <summary>
  /// 著者
  /// </summary>
  public string Author { get; set; } = string.Empty;

  /// <summary>
  /// 出版日
  /// </summary>
  public DateOnly PublishedDate { get; set; }

  /// <summary>
  /// サンプルありフラグ
  /// </summary>
  public bool HasSampleFlag { get; set; }

  /// <summary>
  /// 登録日時
  /// </summary>
  public DateTime UpdatedAt { get; set; }
}
