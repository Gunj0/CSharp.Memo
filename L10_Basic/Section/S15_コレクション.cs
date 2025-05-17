namespace L10_Basic.Section;

internal static class S15_コレクション
{
  internal static void Run()
  {
    Console.WriteLine("\n～～コレクション～～");

    // 配列(要素数は不変)
    var array1 = new int[] { 1, 2 };
    Console.WriteLine($"配列: {array1[0]}");
    // 配列の長さ
    Console.WriteLine($"Length: {array1.Length}");
    // 2次元配列
    var array2 = new int[,]
    {
      { 1, 2, 3 },
      { 4, 5, 6 }
    };
    Console.WriteLine($"2次元配列: {array2[0, 0]}");
    // 2次元配列の長さを取得
    Console.WriteLine($"Length: {array2.Length}");
    Console.WriteLine($"GetLength: {array2.GetLength(0)}");

    // List
    var list = new List<int> { 3, 4 };
    Console.WriteLine($"List: {list[0]}");
    // Listの長さ
    Console.WriteLine($"Count: {list.Count}");
    // Listに追加
    list.Add(5);
    // Listに追加(複数)
    list.AddRange([6, 7]);
    // Listから削除(値指定)
    list.Remove(3);
    // Listから削除(インデックス指定)
    list.RemoveAt(0);
    // Listから削除(複数)
    list.RemoveAll(x => x > 5);
    // Listのインデックス取得
    var index = list.IndexOf(4);
    // Listのインデックス取得(複数)
    var indexes = list.FindAll(x => x > 4);
    // 全て削除
    list.Clear();

    // foreach
    foreach (var item in array1)
    {
      Console.WriteLine($"foreach: {item}");
    }
  }
}
