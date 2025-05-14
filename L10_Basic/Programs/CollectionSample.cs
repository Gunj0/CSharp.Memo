namespace CSharp.Memo.BasicSample
{
  internal static class CollectionSample
  {
    internal static void Collections()
    {
      Console.WriteLine("～～CollectionSample～～");

      // 配列（要素数は不変）
      var array = new int[2];
      array[0] = 1;
      array[1] = 2;
      // 要素数
      var length = array.Length;
      foreach (int i in array)
      {
        Console.WriteLine(i);
      }

      // List（基本こっちを使う）
      var list = new List<int>();
      list.Add(3);
      list.Add(4);
      list.Add(5);
      // 要素数
      var count = list.Count;
      // インデックス削除
      list.RemoveAt(0);
      // 中身指定削除
      list.Remove(5);
      foreach (int i in list)
      {
        Console.WriteLine(i);
      }
      // 全て削除
      list.Clear();

      Console.WriteLine("");
    }
  }
}
