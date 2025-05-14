namespace CSharp.Memo.BasicSample
{
  /// <summary>
  /// 型変換
  /// </summary>
  internal static class ConvertSample
  {
    internal static void Converts()
    {
      Console.WriteLine("～～ConvertSample～～");

      // 型キャスト
      double d = 1.2d;
      int i = (int)d;
      Console.WriteLine(i);

      // Parse(エラーは例外で捕捉する)
      string value1 = "10";
      int intValue1 = int.Parse(value1);
      Console.WriteLine(intValue1);

      // TryPase(エラーはboolで捕捉する)
      string value2 = "11";
      int intValue2;
      bool result = int.TryParse(value2, out intValue2);
      Console.WriteLine(intValue2);

      // convert(エラーは例外で捕捉する)
      string value3 = "12";
      int intValue3 = Convert.ToInt32(value3);
      Console.WriteLine(intValue3);


      Console.WriteLine("");
    }
  }
}
