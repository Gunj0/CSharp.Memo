int // 整数(値型)
double // 小数(値型)
decimal // 精密な小数(値型) =1.0m(m サフィックス)で初期化する。
char // 文字(値型)
string // 文字列(参照型)
bool // ブール型(値型)
object // 全ての基底となる型

配列(参照型) // 要素数が変更不可
初期化なし
var num = new int[3];
初期化あり
var num = new int[]{1, 2, 3};

List<T> // 要素数が変更可
基本
初期化なし
var list = new List<string>();
初期化あり
var list = new List<string>
{
"a", "b", "c",
}
メソッド
list.Add("d"); // 要素の追加
list.Count; // 要素数
list.RemoveAt(2); // 要素の削除(要素番号指定)
list.Clear(); // 要素を全て削除

Dictionary(ハッシュテーブル) // キーと値のペアを保持する
var capital = new Dictionary<String, String>();
capital["日本"] = "東京";
capital["USA"] = "NY";
foreach(var key in capital.Keys)
{
Console.WriteLine($"{capital[key]} in {key}");
}

HashSet(ハッシュセット) // 重複なしリスト
var set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(1); // 重複値は登録されない

クラス(参照型)
基本
namespace Example
{
class Book
{
// プロパティ
public int Id { get; set; }
// フィールド
private int \_rate;
// メソッド
public void Print()
{
Console.WriteLine(Id);
}
// コンストラクタ
public Book() // インスタンス化時のみ実行
{
\_rate = 3;
}
// デストラクタ // インスタンス破棄時に実行
~Book()
{
Console.WriteLine("削除");
}
}
}
インスタンス化(オブジェクト化)
初期化なし
var book = new Book();
初期化あり
var book = new Book // 初期化時は、()をつけなくてもよい
{
Id = 1,
};

プロパティ
基本
public int Rate1 { get; set; } // 数値型は自動で初期値 0 になる
public int Rate2 { get; set; } = 1; // 初期値
旧表記(代入値等をいじれる)
private int \_rate;
public int Rate
{
get
{
return \_rate; // get アクセサ
}
set
{
return = value; // set アクセサ(value に代入値が入る)
}
}
読み取り専用プロパティ
// コンストラクタと class 内メソッドのみ set 可
public string Name1 { get; private set; }
// コンストラクタのみ set 可
public string Name2 { get; }
// get のみ可
public string Name3
{
get { return "本"; }
}

フィールド
private int \_rate; // class 内のみ参照可(private は省略可)

メソッド
class Program()
{
static void Main() // Main メソッド(エントリーポイント)は必ず static
{
Print();
}
static void Print() // Main メソッドと同じクラス内では必ず static
{
Console.WriteLine("プリント");
}
}

列挙型(値型)
enum Card // 実体は int 型
{
red = 0, // 数値は省略可能
white = 1,
}
var week = DayOfWeek.Friday; // DayOfWeek のみ代入可能になのでバグが減る
構造体(値型)
struct Book // 基本はクラスと同じ。クラス使用推奨。
{
// プロパティ、フィールド、メソッド、コンストラクタ
}

値型と参照型
参照型： アドレスがメモリ(ヒープ)に格納される
クラスをクラスに代入してその後片方の中身を変更すると、もう片方にも反映される
→ 引数でインスタンスを渡すとアドレスが渡されるので元のインスタンスにも影響が出る
値型： 値そのものがメモリ(スタック)に格納される
構造体を構造体に代入してその後片方の中身を変更しても、もう片方には反映されない
→ 引数でインスタンスを渡すとコピーが渡される
Null
string str = null; // 参照型は null 代入可能
int? num = null; // 値型は?をつけると null 許容型になる(処理遅くなる)
int a = (int)num; // キャストすると null 許容型から値を取り出せる
int a = num.Value; // Value プロパティでも値を取り出せる
値が null の時に変換するとエラーになるので注意(条件分けする)
if(num.HasValue){ // num != null と同じ
int a = num.Value;
}
static 修飾子
静的メソッド // インスタンス化不要
var time = DateTime.IsLeapYeay(2022);
静的プロパティ // インスタンス化不要
var time = DateTime.Today;
静的クラス // 全て static メソッド・プロパティ必須
var line = Console.ReadLine(); // Console クラスは static

LINQ: Language Integrated Query
基本 ※配列や List に使える。元のコレクションには影響を与えない
Where
var list = nums.Where(x => x => 2); // 条件一致を取り出す
var list = books.Where(x => x.Title == "本"); // 条件一致を取り出す
Select
var list = nums.Select(x => x \* 2); // 各要素に処理をする
var list = books.Select(x => x.Title); // 各要素の変換をする
OrderBy
var list = nums.OrderBy(x => x); // 昇順にする
var list = nums.OrderByDescending(x => x); // 降順にする
var list = books.OrderBy(x => x.Title); // オブジェクト要素でも可能
From
var data = from list in Lists // 取得ソースを指定する
select new { Url = list.Url } // より詳しい条件を指定できる？
その他
var list = nums.Take(2) // 先頭から数値分の要素を取り出す
var list = nums.Distinct(); // 重複を排除する
var num = nums.Sum(); // 合計する
var num = nums.Max(); // 最大値を取り出す
var num = nums.First(); // 最初の要素を取り出す
var flag = nums.Any(x => x > 0); //条件を満たすものがあれば True
ToArray/ToList
// LINQ は IEnumerable<T>を返すので、配列や List に変換する必要がある。
var list = nums.OrderBy(x => x).ToList();

継承(派生=is a 関係)
図：基底クラス(スーパークラス)← 派生クラス(サブクラス)
基本
class Employee : Person // C#は継承元は 1 つだけ
{
// Person のプロパティ、メソッドを定義したことになる
public int Number { get; set; }
}
コンストラクタに引数がある場合
// 基底クラスで引数があるコンストラクタを定義したら派生クラスでも定義が必要
class Employee : Person
{
// base(name)で基底クラスのコンストラクタを呼び出す
public Employee(string name) : base(name)
{
// 基底クラスのコンストラクタの後、ここの処理を実行する
}
}
オーバーライド
abstract class Person // 抽象クラス(インスタンス生成禁止)
{
public virtual void Print() // 仮想メソッド(オーバーライド可能)
{
Console.WriteLine("ほげ");
}
public abstract void Eat(); // 抽象メソッド(オーバーライド必須)
}
class Employee : Person
{
public override void Print() // オーバーライド
{
Console.WriteLine("ほげほげ");
}
public override void Eat() // オーバライド
{
Console.WriteLine("ふが");
}
}
代入
Person person = new Employee(); // 派生は基底の変数に代入可
var persons = new List<Person>
{
new Employee(), // 基底 List に派生も代入可
}
ポリモーフィズム(多態性、多相性)
// 異なる型のオブジェクトを同じと見なし、同じ名前で別々のメソッドを呼び出せること
class Program
{
static void Main()
{
VirtualPet pet1 = new FoodiePet();
VirtualPet pet2 = new CheerfulPet();
var pets = new List<VirtualPet>
{
pet1, pet2, // 同じ基底クラスのオブジェクトを同列で扱える
}
foreach(var pet in pets)
{
pet.Eat(); // 同じ名前で中身が別々のメソッドを呼び出せる
}
}
}

インターフェイス
// メソッド・プロパティのシグネチャー(名前、型、引数等の情報)のみを定義したもの
interface IVirtualPet
{
// public, private 等はつけない
string Name { get; } // get のみ public 必須になる
int Mood { get; set; } // get, set どちらも public 必須
void Eat(); // 実装必須になる(引数指定可)
}
class FoodiePet : Base, IVirtualPet, ICommand // 継承に加えて複数実装可
{
public string Name { get; private set;} // set は任意
public int Mood { get; set; }
public void Eat() // override はいらない
{
Console.WriteLine("食");
}
}
void Main()
{
var pets = new List<IVirtualPet>(); // ポリモーフィズム可能
}

例外処理
基本
try
{
Do(); // Do メソッド内の例外発生してもキャッチできる
// Do メソッド内で try-catch が書いてある場合はそちらの処理だけで終わる
}
catch // 例外が発生した瞬間にこっちの処理に移る
{
Something();
}
例外クラス
// 全て System.Exception から派生する
// 例外が発生するとその種類に応じた例外オブジェクトが生成される
try
{
var num = 10 / 0;
}
catch(System.DivideByZeroException) // 上から順にキャッチする
{
Console.WriteLine("0 割");
}
catch(System.Exception) // Exception で全てキャッチできる
{
Console.WriteLine("その他");
}
例外の中身
try
{
// 処理
}
catch(Exception ex) // ex に例外オブジェクトを代入
{
Console.WriteLine(ex.GetType().Name); // 例外クラス名
Console.WriteLine(ex.Message); // 例外メッセージ
Console.WriteLine(ex.TargetSite); // 例外が発生したメソッド名
Console.WriteLine(ex.StackTrace); // 発生箇所
}
例外を投げる
if(num > 10)
{
throw new ArgumentException("10 より大きい"); // Message を引数にする
}

後処理
基本
try
{
var file = new StreamReader("test.txt"); // ファイル読み込み
while(file.EndOfStream == false) // 最終行かどうか判定
{
var line = file.ReadLine(); // 一行読み込み
Console.WriteLine(line);
}
}
finally // 例外発生時も、後処置をしたあとに catch に移る
{
file.Dispose(); // ファイルを閉じる
}
using
// IDiposable(Dispose のインターフェイス)を実装したクラスでのみ使える
using (var obj = new Do()) // 処理を抜けると必ず Dospose される
{
}

デリゲート(委譲)
// 別々のクラスのメソッドを参照するオブジェクト。主にイベントと発生処理を紐づける。
基本
delegate void Action(int a, int b); // 宣言
class ClassA
{
public void MethodA(int a, int b)
{
Console.WriteLine($"{a}&{b}");
			}
		}
		class ClassB
		{
			public void MethodB(int a, int b)
			{
				Console.WriteLine($"{a}+{b}");
}
}
class Program
{
static void Main()
{
var a = new ClassA();
var b = new ClassB();
// デリゲートの設定(同じ引数、戻り値の型なら OK)
var o = new Action(a.MethodA);
o(2, 1); // 実際のメソッドをマスクして実行できる
o += new Action(b.MethodB); // 処理を複数追加できる
}
}

using ディレクティブ
基本
using System; // Console 等
using System.Collections.Generic; // List<T>等
using System.Linq; // LINQ
using System.Text; //
using System.Threading.Tasks; //

アクセス修飾子
public : どこからでもアクセス可
protected : クラス内とサブクラス内のみアクセス可
private : クラス内のみアクセス可

ガーベージコレクション
GC.Collect(); // 使用していないメモリの清掃
GC.GetTotalMemory(false) // PC メモリ使用量出力

その他
const キーワード
// 再代入するとエラー発生する
const int NUM = 1;
is 演算子
// オブジェクトの実際の派生クラスを調べる
if(pet is FoodiePet){}
as 演算子
// オブジェクトを派生クラスや基底クラスへ変換する(参照型のみ。()キャストは値型も OK)
var fp = pet as FoodiePet;
out キーワード
// メソッドの戻り値でなく引数で値を返すという指定
if(int.TryParse(str, out var num) ) // TraParse は変換できなければ false を返す
{
// num に変換後の数値が入る
}
書式
Console.WriteLine("{0:.00}", record); // 小数点以下 2 桁で出力
Console.WriteLine("{0,2:d}", num); // 2 桁の整数を右揃え出力
拡張メソッド
クラスを継承することなく元のクラスにメソッドを追加できる
public static class StringExtender
{
// 拡張メソッド(static, this が必須)
public static int hex2Int(this string s)
{
return Convert.ToInt32(s, 16);
}
}
DTO
class Book // プロパティのみのクラス。Model⇔ViewModel 等
{
public int Id { get; set; }
public string Title { get; set; }
}

【用語】
・ジェネリッククラス:List<T>等、T に型を指定してインスタンス生成するクラス
・ラムダ式:(x => x >= 1)等のこと。x はコレクションの各要素、=>はラムダ演算子を表す
・オーバーロード(多重定義):引数の異なる同名関数を複数定義すること
・CLR（共通言語ランタイム）:C#等を変換した CIL（共通中間言語）の動作環境

【疑問】
・テストの書き方
・C#のプログラム開始は Main メソッド以外にできる？　エントリーポイント
複数ある場合は？クラス名の指定は？namespace は？
・非同期処理
・ログ出力方法
