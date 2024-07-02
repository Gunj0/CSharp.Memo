using CSharp.Memo.BasicSample;

/* BasicSample */
// 文字チェック
InputCheckSample.InputCheck();
// ファイル入出力
FileIOSample.FileIO();
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

// 



// 止める用
Console.ReadLine();