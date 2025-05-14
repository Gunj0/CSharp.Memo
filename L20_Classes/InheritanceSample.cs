namespace CSharp.Memo.AdvancedSample
{
  internal class Super
  {
    private int _num;

    public Super(int num)
    {
      _num = num;
    }

    // virtualは書き換え可能（書き換えなくても可）
    public virtual void Add()
    {
      int a = _num + 10;
    }
  }

  // インターフェース以外は多重継承不可
  internal class InheritanceSample : Super
  {
    public InheritanceSample(int num) : base(num)
    {
      Console.WriteLine("～～InheritanceSample～～");
      Console.WriteLine(num);
      Console.WriteLine("");
    }

    // overrideで継承元の書き換え
    public override void Add()
    {
      // 元のメソッド
      base.Add();

      Console.WriteLine("");
    }
  }
}