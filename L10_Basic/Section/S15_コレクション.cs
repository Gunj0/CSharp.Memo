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
    // Count
    Console.WriteLine($"Count: {list.Count}");
    // Add
    list.Add(5);
    // AddRange: 複数要素を追加
    list.AddRange([6, 7]);
    // Remove: 指定要素を削除
    list.Remove(3);
    // RemoveAt: 指定インデックスの要素を削除
    list.RemoveAt(0);
    // RemoveAll: 条件に合致する要素を削除
    list.RemoveAll(x => x > 5);
    // IndexOf: インデックス取得
    var index = list.IndexOf(4);
    // FindAll: 条件に合致する要素を取得
    var indexes = list.FindAll(x => x > 4);
    // Clear: 全て削除
    list.Clear();

    // foreach
    foreach (var item in array1)
    {
      Console.WriteLine($"foreach: {item}");
    }
  }
}
