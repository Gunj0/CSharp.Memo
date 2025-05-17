namespace L10_Basic.Section;

internal static class S25_値型と参照型
{
  internal static void Run()
  {
    Console.WriteLine("\n～～値型と参照型～～");

    // 値型
    int a = 1;
    int b = a; // 値のコピー
    b = 2;
    Console.WriteLine($"値型: {a}, {b}");

    // 参照型
    var obj1 = new SampleClass { Value = 1 };
    var obj2 = obj1; // 参照のコピー
    obj2.Value = 2;
    Console.WriteLine($"参照型: {obj1.Value}, {obj2.Value}");
  }
}

internal class SampleClass
{
  internal int Value { get; set; }
}
