using System.ComponentModel;
using System.Text;

namespace L10_Basic.Section;

internal static class S60_File
{
  internal static void Run()
  {
    Console.WriteLine("\n～～File～～");

    // ファイル出力
    using (var sw = new StreamWriter(
      "IOSample.txt", // 絶対パスでも相対パスでも可
      true,           // trueは追記、falseは上書き
      Encoding.GetEncoding("UTF-8")
      ))
    {
      sw.WriteLine($"{DateTime.Now},晴れ");
    }
    Console.WriteLine($"ファイル出力");

    // ファイル存在チェック
    if (!File.Exists("IOSample.txt")) return;
    Console.WriteLine($"ファイル存在チェック");

    // ReadAllLines(全ての行を配列に読み込んでから処理する)
    var _dtos = new List<OutputFileDto>();
    var lines = File.ReadAllLines(
      "IOSample.txt",
      Encoding.GetEncoding("UTF-8")
      );
    foreach (var line in lines)
    {
      var row = line.Split(',');
      var dto = new OutputFileDto(
        DateTime.Parse(row[0]),
        row[1]
        );
      _dtos.Add(dto);
    }
    foreach (var dto in _dtos)
    {
      Console.WriteLine($"ReadAllLines: {dto.Id}: {dto.Time}: {dto.Weather}");
    }

    // StreamReader(一行ずつ読み込みつつ処理する)
    using (var sr = new StreamReader(
      "IOSample.txt",
      Encoding.GetEncoding("UTF-8")
      ))
    {
      var line = sr.ReadLine();
      while (line != null)
      {
        var row = line.Split(',');
        var dto = new OutputFileDto(
          DateTime.Parse(row[0]),
          row[1]
          );
        _dtos.Add(dto);
        Console.WriteLine($"StreamReader: {dto.Id}: {dto.Time}: {dto.Weather}");
        line = sr.ReadLine();
      }
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
