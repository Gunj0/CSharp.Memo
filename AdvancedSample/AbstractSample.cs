namespace CSharp.Memo.AdvancedSample
{
  internal abstract class Abstracts
  {
    public void Save()
    {
      Before();
      Execute();
    }

    // 抽象メソッド（定義だけ）
    protected abstract void Execute();

    // 普通の処理も書ける
    private void Before()
    {
    }
  }

  internal class AbstractSample : Abstracts
  {
    protected override void Execute()
    {
      Console.WriteLine("～～AbstractSample～～");
      Console.WriteLine("抽象クラス");
      Console.WriteLine("");
    }
  }
}
