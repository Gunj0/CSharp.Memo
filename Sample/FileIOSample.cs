using System.Text;

namespace CSharp.Memo.Sample
{
  /// <summary>
  /// ファイル入出力
  /// </summary>
  internal static class FileIOSample
  {
    internal static void FileIO()
    {
      using var sw = new StreamWriter(
        @"C:\Users\gunjo\VS\test.txt",
        false,      // trueは追記、falseは上書き
        Encoding.GetEncoding("utf-8")
        );
      sw.WriteLine(DateTime.Now);
    }
  }
}
