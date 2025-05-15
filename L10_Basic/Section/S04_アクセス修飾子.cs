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

// ■ アクセス修飾子
// ・public:どこからでもアクセス可
// ・protected internal:派生クラスと同じアセンブリ内のみ
// ・protected:同じクラスと派生クラス内のみ
// ーーーーーーーーー ↑ 公開、↓ 非公開ーーーーーーーーー
// ・internal:同じプロジェクト(アセンブリ)内のみ
// ・private protected:同じアセンブリ内の派生クラス内のみ
// ・private:同じクラス内のみ
