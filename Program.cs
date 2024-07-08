using CSharp.Memo.AdvancedSample;
using CSharp.Memo.BasicSample;
using CSharp.Memo.LambdaSample;

/* BasicSample */
// 文字チェック
InputCheckSample.InputCheck();
// ファイル入出力
//FileIOSample.FileIO();
// 型変換
ConvertSample.Converts();
// コレクション
CollectionSample.Collections();
// コンストラクタ
new ConstructorSample(1, "田中").Call();
// アクセス修飾子
new AccessModifierSample().PublicCall();
// プロパティ
var count = new PropertySample().Count4;

/* AdvancedSample */
// Dispose
new DisposeSample().Dispose();
// 継承
new InheritanceSample(10);
// インターフェース+ポリモーフィズム
var list = new List<ISample1>();
list.Add(new InterfaceSample1());
list.Add(new InterfaceSample2());
foreach (var item in list)
{
  item.Save();
}
// 抽象クラス
new AbstractSample().Save();
// 例外処理
//new ExceptionSample();

/* ラムダ式 */
// Delegate
new DelegateSample().Delegates();
// 匿名メソッド
new AnonymousMethodSample().AnonymousMethod();
// Predicate
new PredicateSample().Predicates();
// ラムダ式
new LambdaSample().Lambdas();
// Func, Action
new FuncActionSample().FuncActions();









// 止める用
Console.ReadLine();