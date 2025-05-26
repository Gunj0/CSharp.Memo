using System.ComponentModel;
using System.Text;

namespace L10_Basic.Section;

internal static class S60_File
{
  internal static void Run()
  {
    Console.WriteLine("\n～～File～～");

    // ファイル出力
    var outputFilePath = @"IOSample.txt";
    using (var sw = new StreamWriter(
      outputFilePath, // 絶対パスでも相対パスでも可
      true,           // trueは追記、falseは上書き
      Encoding.GetEncoding("UTF-8")
      ))
    {
      sw.WriteLine($"{DateTime.Now},晴れ");
    }
    Console.WriteLine($"{outputFilePath}: ファイル出力完了");

    // ファイル読み込み
    var inputFilePath = @"IOSample.txt";
    // 存在チェック
    if (!File.Exists(inputFilePath)) return;

    // 一行ずつ読み込み
    string[] lines = File.ReadAllLines(
      inputFilePath, // 絶対パスでも相対パスでも可
      Encoding.GetEncoding("UTF-8")
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
  }
}

internal sealed class OutputFileDto
{
  public OutputFileDto(DateTime time, string weather)
  {
    Id = _id;
    Time = time;
    Weather = weather;
    // インスタンス生成の度にIDをインクリメント
    _id++;
  }

  private static int _id = 0;

  internal int Id { get; }
  internal DateTime Time { get; } = new DateTime();
  internal string Weather { get; } = "";
}
