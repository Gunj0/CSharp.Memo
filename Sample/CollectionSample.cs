namespace CSharp.Memo.Sample
{
  internal static class CollectionSample
  {
    internal static void Collections()
    {
      Console.WriteLine("～～CollectionSample～～");

      // 配列
      var array = new int[2];
      array[0] = 1;
      array[1] = 2;
      foreach (int i in array)
      {
        Console.WriteLine(i);
      }

      // List
      var list = new List<int>();
      list.Add(3);
      list.Add(4);
      list.Add(5);
      // インデックス削除
      list.RemoveAt(0);
      // 中身指定削除
      list.Remove(5);
      foreach (int i in list)
      {
        Console.WriteLine(i);
      }


      Console.WriteLine("");
    }
  }
}
