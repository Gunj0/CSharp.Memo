namespace L10_Basic.Section;

internal static class S15_演算子
{
  internal static void Run()
  {
    Console.WriteLine("\n～～L10-S15 演算子～～");

    // 算術演算子
    var a = 10 + 5; // 足し算
    var b = 10 - 5; // 引き算
    var c = 10 * 5; // 掛け算
    var d = 10 / 5; // 割り算
    var e = 10 % 5; // 割り算の余り
    Console.WriteLine($"足し算: {a}, 引き算: {b}, 掛け算: {c}, 割り算: {d}, 割り算の余り: {e}");

    // 代入演算子
    var x = 10;
    x += 5;
    Console.WriteLine($"代入演算子: {x}");

    // 関係演算子
    var isEqual = (10 == 5); // 等しい
    var isNotEqual = (10 != 5); // 等しくない
    var isGreater = (10 > 5); // より大きい
    var isLess = (10 < 5); // より小さい
    var isGreaterOrEqual = (10 >= 5); // より大きいか等しい
    var isLessOrEqual = (10 <= 5); // より小さいか等しい
    Console.WriteLine($"等しい: {isEqual}, 等しくない: {isNotEqual}, より大きい: {isGreater}, より小さい: {isLess}, より大きいか等しい: {isGreaterOrEqual}, より小さいか等しい: {isLessOrEqual}");

    // 論理演算子
    var and = (true && false); // AND
    var or = (true || false); // OR
    var not = !true; // NOT
    Console.WriteLine($"AND: {and}, OR: {or}, NOT: {not}");
  }
}
