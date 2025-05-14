using System.Diagnostics;

namespace CSharp.Memo._10_CSharpNote
{
  internal class _40_デバッグ
  {
    // DEBUGのときだけ実行
#if DEBUG
    int hoge = 10;
#endif

    // DEBUG以外のときだけ実行
#if !DEBUG
    int hoge = 10;
#endif

    // 自動ウィンドウ: 実行している近くの変数が見れる
    // ローカルウィンドウ: 現在のメソッド内の引数や変数が見れる
    // ウォッチウィンドウ: 固定して変数を見れる

    public int Get()
    {
      Debug.WriteLine("");
      return 0;
    }
  }
}
