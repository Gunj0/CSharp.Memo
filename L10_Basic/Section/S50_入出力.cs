using System.ComponentModel;
using System.Text;

namespace L10_Basic.Section;

internal static class S05_入出力
{
  internal static void Run()
  {
    Console.WriteLine("～～L10-S05 入出力～～");

    // .NETではShift-JISが標準で登録されていないので登録する
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

    // ファイル出力
    var outputFilePath = @"IOSample.txt";
    using (var sw = new StreamWriter(
      outputFilePath, // 絶対パスでも相対パスでも可
      true,           // trueは追記、falseは上書き
      Encoding.GetEncoding("shift_jis")
      ))
    {
      sw.Write(DateTime.Now);
      sw.Write(",");
      sw.Write("晴れ");
      sw.WriteLine();
    }
    Console.WriteLine($"{outputFilePath}: ファイル出力完了");

    // ファイル読み込み
    var inputFilePath = @"IOSample.txt";
    // 存在チェック
    if (!File.Exists(inputFilePath)) return;
    // 一行ずつ読み込み
    string[] lines = File.ReadAllLines(
      inputFilePath, // 絶対パスでも相対パスでも可
      Encoding.GetEncoding("shift_jis")
      );
    // BindingListは、DataGridViewをリアルタイム更新できるList
    var _dtos = new BindingList<OutputFileDto>();
    foreach (var line in lines)
    {
      string[] row = line.Split(',');
      var dto = new OutputFileDto(
        DateTime.Parse(row[0]),
        row[1]
        );
      _dtos.Add(dto);
    }
    foreach (var dto in _dtos)
    {
      Console.WriteLine($"{dto.Id}: {dto.Time}: {dto.Weather}");
    }




    Console.WriteLine("");
  }
}

/// <summary>
/// DTOサンプル（実際はクラスごとにファイルを分ける）
/// sealedは継承できないようにする
/// </summary>
internal sealed class OutputFileDto
{
  // コンストラクタ
  public OutputFileDto(DateTime time, string weather)
  {
    Id = _id;
    Time = time;
    Weather = weather;
    // インスタンス生成の度にIDをインクリメント
    _id++;
  }

  private static int _id = 0;

  /// <summary>
  /// ID
  /// </summary>
  internal int Id { get; }

  /// <summary>
  /// 日時
  /// </summary>
  internal DateTime Time { get; } = new DateTime();

  /// <summary>
  /// 日時
  /// </summary>
  internal string Weather { get; } = "";
}

