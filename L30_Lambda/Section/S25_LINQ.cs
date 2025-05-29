namespace L30_Lambda.Section;

internal static class S25_LINQ
{
  internal static void Run()
  {
    // LINQ: Language Integrated Query
    Console.WriteLine("\n～～LINQ～～");

    var numbers = new List<int> { 1, 3, 2, 4, 5, 2 };

    // Where: 条件に合致する要素を取得
    var evenNumbers = numbers.Where(n => n % 2 == 0);
    Console.WriteLine($"Where: " + string.Join(", ", evenNumbers));

    // Select: 各要素に対して変換を適用
    var squaredNumbers = numbers.Select(n => n * n);
    Console.WriteLine($"Select: " + string.Join(", ", squaredNumbers));

    // OrderBy: 昇順でソート
    var sortedNumbers = numbers.OrderBy(n => n);
    Console.WriteLine($"OrderBy: " + string.Join(", ", sortedNumbers));

    // Take: 最初のN個の要素を取得
    var firstThreeNumbers = numbers.Take(3);
    Console.WriteLine($"Take: " + string.Join(", ", firstThreeNumbers));

    // Distinct: 重複を排除
    var distinctNumbers = numbers.Distinct();
    Console.WriteLine($"Distinct: " + string.Join(", ", distinctNumbers));

    // Sum: 合計を計算
    var sumOfNumbers = numbers.Sum();
    Console.WriteLine($"Sum: {sumOfNumbers}");

    // Max: 最大値を取得
    var maxNumber = numbers.Max();
    Console.WriteLine($"Max: {maxNumber}");

    // Any: 条件に合致する要素が存在するか確認
    var hasEvenNumber = numbers.Any(n => n % 2 == 0);
    Console.WriteLine($"Any: {hasEvenNumber}");

    // FirstOrDefault: 条件に合致する最初の要素を取得、存在しない場合はデフォルト値
    var firstEvenNumber = numbers.FirstOrDefault(n => n % 2 == 0);
    Console.WriteLine($"FirstOrDefault: {firstEvenNumber}");

    // LINQ to Objects
    // - クエリー式構文 // シンプルだが表現できない式もある(コンパイラによってメソッド構文に置換される)
    // - メソッド構文 // 冗長だが全てを表現できる

    // LINQ to Entities
    // - クエリー式構文 // シンプルだが表現できない式もある(コンパイラによってメソッド構文に置換される)
    // - メソッド構文 // 冗長だが全てを表現できる
  }
}


