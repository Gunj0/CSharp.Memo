namespace CSharp.Memo.AdvancedSample
{
  internal interface ISample1
  {
    // 定義だけ書く。アクセス修飾子もなし。
    void Save();
  }

  internal interface ISample2
  {
    void Add();
  }

  // インターフェースは多重継承可
  internal class InterfaceSample1 : ISample1, ISample2
  {
    public void Save()
    {
      Console.WriteLine("～～InterfaceSample～～");
      Console.WriteLine("ポリモーフィズム1");
    }

    public void Add()
    {
    }
  }

  internal class InterfaceSample2 : ISample1
  {
    public void Save()
    {
      Console.WriteLine("ポリモーフィズム2");
      Console.WriteLine("");
    }
  }
}
