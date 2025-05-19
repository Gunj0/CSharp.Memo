namespace L10_Basic.Section;

internal static class S65_Math
{
  internal static void Run()
  {
    Console.WriteLine("\n～～Math～～");

    // Math.Abs(絶対値)
    var abs = Math.Abs(-1);
    Console.WriteLine($"Math.Abs: {abs}");

    // Math.Max(最大値)
    var a = 1;
    var b = 2;
    var c = Math.Max(a, b);
    Console.WriteLine($"Math.Max: {c}");

    // Math.Floor(切り捨て)
    var floor = Math.Floor(1.5);
    Console.WriteLine($"Math.Floor: {floor}");

    // Math.PI(円周率)
    var pi = Math.PI;
    Console.WriteLine($"Math.PI: {pi}");

    // Math.Pow(xのy乗)
    var pow = Math.Pow(2, 3);
    Console.WriteLine($"Math.Pow: {pow}");

    // Math.Sqrt(平方根)
    var sqrt = Math.Sqrt(4);
    Console.WriteLine($"Math.Sqrt: {sqrt}");
  }
}
