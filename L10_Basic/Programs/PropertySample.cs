namespace CSharp.Memo.BasicSample
{
  internal class PropertySample
  {
    /// <summary>
    /// 通常のプロパティ
    /// </summary>
    public int Count1 { get; set; }

    /// <summary>
    /// 読み取り専用プロパティ
    /// </summary>
    public int Count2 { get; }

    /// <summary>
    /// 読み取り専用、クラス内のみセット可能なプロパティ
    /// </summary>
    public int Count3 { get; private set; }

    /// <summary>
    /// 条件を付与する場合のgetter、setter
    /// </summary>
    private int _count = 0;
    public int Count4
    {
      get
      {
        Console.WriteLine("～～PropertySample～～");
        Console.WriteLine(_count);
        Console.WriteLine("");
        return _count;
      }

      set
      {
        if (value < 0)
        {
          _count = 0;
        }
        else
        {
          _count = value;
        }
      }
    }
  }
}
