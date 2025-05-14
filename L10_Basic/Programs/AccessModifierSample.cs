namespace CSharp.Memo.BasicSample
{
  public class AccessModifierSample
  {
    // �ǂ�����ł��A�N�Z�X��
    public void PublicCall()
    {
      Console.WriteLine("");
    }

    // ����A�Z���u���iexe, dll�j����A�N�Z�X��
    internal int Num { get; set; }

    // �N���X�����Ƃ��̔h���N���X����A�N�Z�X��
    protected string? Name { get; set; }

    // internal + protected�̗����͈̔�
    internal protected decimal? Value { get; set; }

    // �N���X�����̂�
    private double Temperature { get; set; }
  }
}
