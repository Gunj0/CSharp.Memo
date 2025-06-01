# 【C#】C Sharp .cs

## C#について

■ クラスのメンバー
・データメンバー
フィールド(変数メンバー):データの入れ物。通常は private。\_をつける。
定数:不変データ
・関数メンバー
メソッド:機能
コンストラクタ:初期化時の機能
プロパティ:フィールドへアクセスする手段(getter+setter)
インデクサ:
ファイナライザ:

■ フィールドとローカル変数
・ローカル変数: メソッド内で宣言した変数
・フィールド: クラス直下の変数, var が使えない

■ 値型と参照型
・値型: bool, int, double → 実際の値が入る
・参照型: 上記以外(string, object) → メモリアドレスが入る
・参照型は==で比較するとアドレス同士の比較になる
・参照型の中身の比較は Epuals
・配列同士の中身の比較は SequenceEqual

■null
・基本は参照型のみ null が初期値
string str = null;
・値型でも?をうしろにつけると null 許容型になる
int? num = null; Nullable<int> num = null;
・null にアクセスすると null 参照エラーになる
str.Trim();
・?を使うと null のときもエラーにならず null が返される
str?.Trim();
・null 許容型は HasValue, Value といったプロパティが使える
C#8.0 以降はデフォルトで null 禁止
・参照型でも null を使うには string?とすることが必要
（プロジェクトプロパティ → ビルド →Null 許容で設定変更）
・null 合体演算子(式 1 が null のときは式 2 を返す)
式 1 ?? 式 2;
・null 合体代入(式 1 が null のときは式 2 を式 1 に代入)
str ??= 123;

■ 配列
int[] data;
int[] data = new int[5];
int[] data = {1, 2, 3, 4, 5};
var data = new[] {1, 2, 3, 4, 5,};

■unsafe コード
・通常はメモリアクセス等のコードはエラーになる
・unsafe{}でくくってプロジェクトプロパティで有効化することで可能

■nameof 演算子
・nameof(index)とすることでメソッド名等を文字列にできる
・ActionLink 等でメソッド名変更に対応できる

■ コードメトリクス
・「分析」→「コードメトリクスを計算する」でコードの保守性が分かる
・コードメトリクスが高いほど保守性が高い

■ 重い処理(オーバーヘッドがかかるのでループ非推奨)
・try…catch
・オブジェクト生成・破壊
・文字列の結合

■ プリプロセッサディレクティブ
#define DEBUG(これはデフォルト有効なので不要)
#if DEBUG
// デバッグが定義されている時だけやる処理
#endif

■ シグニチャ
・メソッド名＋引数名のこと。

■ ジェネリック<...>
・型の異なるリスト等を同じメソッドで使えるためのもの
・一般的に Type の T を使う

class sampie<T>{
型 T を使った処理
}

■ シングルトン
・デザインパターンの 1 種
・クラスのインスタンスを 1 つしか生成したくない場合に使用
・参考:static クラスとの違い
Singleton パターン再考 static クラスは Singleton パターンに入りますか？ | cloud.config Tech Blog

■static readonly
・基本 const と同じだが、オブジェクトを定義できる。
・const と違い、中身は可変になる。

■params キーワード
可変長引数。params キーワードを引数につけることで、配列を可変長にできる。

static double GetAverage(params double[] nums)
{
double sum = 0;
foreach (var num in nums)
{
sum += num;
}
return sum / nums.Length;
}
→ GetAverage(1, 2, 3.3); // 2.1

■ref キーワード
通常は値型を引数で渡すと値のコピーが渡されるが、
ref キーワードをつけて渡すと値型の参照渡しとなりアドレスがコピーされる

int CountUp(ref int data)
{
data++;
return data;
}
→ int data = 1;
→ CountUp(ref data); // 元の引数にも影響するようになる

■in キーワード
readonly ref のこと。参照渡しをするが、中身を変更されないようにできる。

static void Show(in int c)
{
Concole.WriteLine(c);
c = 10; // これはコンパイルエラーになる
}

■out キーワード
・値を返す専用の参照渡し。ref と in と違い、引数の初期化が不要。
・引数に値が代入されないとエラーになる。

public void GetMaxMin(int x, int y, out int max, out int min)
{
if(x >= y) {max = x; min = y}
else {max = y; min = x};
}
→ GetMaxMin(3, 5, out int resultMax, out int resultMin)

■Tuple
・複数の型を()で一つまとめることができる(2 つ以上で使用可)
・主に複数値戻しに使用する
・out は戻り値が引数に設定されるため、こっちが推奨

public (int max, int min) GetMaxMin(int x, int y)
{
return x >= y ? (x, y) : (y, x);
}
→ var t = GetMaxMin(3, 5);
→ var num = t.max; // 5

・名前がない場合は Item1, Item2 でアクセス可(無名メンバー)
var x = (1, 2);
→ var a = x.Item1;

■ 匿名型
・クラスのないインスタンスを生成できる
・主に LINQ で特定オブジェクトの部分的メンバーを切り出すとき
・各プロパティは読み取り専用になるので、再代入はできない
var info = new { Title = “ほげ”, Price = 1000 };

→ var title = info.Title;

■yield return
・return の処理を終了させない版
・何個でもメソッドの中で使用できる

■ オブジェクト指向の重要キーワード
・カプセル化:使い手に関係ないものは見せない
・継承
・ポリモーフィズム

■ コードスニペット
・prop と入力して tab を 2 回押すと、プロパティのテンプレートが挿入される
・propfull で完全なプロパティ構文を挿入できる

■ インデクサー
変数名[...]の形でアクセスする仕組み

■ キャスト
・アップキャスト
Person p = new BusinessPerson();
・ダウンキャスト
BusinessPerson bp = (BusinessPerson)p;
キャストに失敗した場合はエラーになる

■is
・キャストできる場合にのみ true を返す
・ダウンキャストは失敗する可能性があるのでチェックする

if (p is Student) {  
Student st = (Student)p;
...正しくキャストできた場合の処理... }

・キャスト成功時に変数へ格納する省略構文

if (p is Student st) {  
...正しくキャストできた場合の処理... }

■as
・キャストに失敗した場合 null を返す。参照型のみ使用可

var st = p as Student;
if (st != null) {  
...正しくキャストできた場合の処理... }

■ 拡張メソッド StringExtensions
・既存のクラスにメソッドを追加できる
・static クラスの static メソッドにすること
・第 1 引数として this を付けて拡張するクラスを指定すること

internal static class StringExtensions{
public static string Repeat(this string str, int count){  
 ...メソッドの本体... }

■ ポリモーフィズム 多態性
・同じ名前のメソッドで異なる挙動を実現する

Figure t = new Triangle(10, 30);
Console.WriteLine(t.GetArea());
Figure s = new Square(10, 30);
Console.WriteLine(s.GetArea());

■virtual override
・派生クラスでメソッドを上書きできる
・new だけでも上書きできるが非推奨

■abstract 抽象メソッド
・派生クラスでメソッドのオーバーライドを強制できる
・オーバーライドしないと派生先はインスタンス化できない
・メソッド名のみを定義して中身は書かない

internal abstract class Figure {
public double Width { get; set; }
public double Height { get; set; }  
 public Figure(double width, double height) {  
 this.Width = width;  
 this.Height = height; }  
 public abstract double GetArea();
}

■interface インターフェイス
・メソッドが全て abstract のクラス
・abstract と違い、多重継承が可能
・クラスと同時に継承も可能

interface IFigure {
double GetArea();
}
internal class Triangle : MyClass, IFigure, IHoge { ～

■ 抽象クラスとインターフェイスの使い分け
・型階層の中で共通処理を持たせるなら抽象クラス
・型階層と独立して階層をまたぐならインターフェイス

■ 例外
・try, catch で書く
・例外の変数を使わない場合は書かないでもよい
・stacktrace は辿った処理を出す
・VS の［呼び出し履歴］でも見れる

try {  
 ...例外が発生する可能性があるコード... }
catch (FileNotFoundException ex) {  
 Console.WriteLine(ex.StackTrace); }  
catch (FileNotFoundException) {  
 ...例外型 2 が発生した場合の処理... }
finally {  
 // 例外の有無に関わらずやる処理 }

■ 列挙型 enum
・関連する定数群をまとめる
public enum Season{
Spring,  
 Summer,  
 Autumn,
Winter,
}

■ 構造体 struct
・値を代入するため高速
・ただし値が大きくなればオーバーヘッドも大きい
・継承はできない

■ デリケート delegate
・メソッドを変数、引数に代入できるようにする仕組み
・デリゲートと引数、戻り値が同じメソッドを代入できる
・複数メソッドを代入可(マルチキャストデリゲート)

delegate void Process(string str);
internal class DelegateBasic{
static void Run(string s){  
 Console.WriteLine($"{s}走ります。"); }  
 static void Main(string[] args){  
 var p = new Process(Run);
p("ちょこちょこ"); }  
}

delegate void OutputProcess(string str);  
internal class DelegateUse {  
 void ArrayWalk(string[] data, OutputProcess output) {
foreach (var value in data) {  
 output(value); } }  
 static void AddQuote(string data) {  
 Console.WriteLine($"［{data}］"); }  
 static void Main(string[] args) {  
 var data = new[] { "あかまきがみ", "あおまきがみ" };  
 var du = new DelegateUse();  
 OutputProcess proc = AddQuote;  
 du.ArrayWalk(data, proc); }  
}

■ 匿名メソッド
・名前を持たないメソッド
・デリゲートのメソッドは使い捨てなので省略するために使う

dm.ArrayWalk(data, delegate(string d) {
return $"［{d}］";
});

■Func デリゲート
・ライブラリにあるジェネリックデリケート

public delegate TResult Func<in T, out TResult>(T arg)

■ ラムダ式
・匿名のさらに省略記法

dl.ArrayWalk(data, (d) => $"［{d}］" );

■LINQ
・データにアクセスする統一的な手法

独習 C# メモ

【C#について】
■C#はマルチパラダイム言語（p.29）
・オブジェクト指向プログラミング：中心
・宣言型プログラミング(LINQ):どんな条件でどんな形式のデータを取り出すか
・関数型プログラミング(ラムダ式):関数を組み合わせる
・メタプログラミング(リフレクション):コードを表すためのコード。
等のパラダイム(思想)を含んでいる(p.4)

【備忘】
■ アクセス修飾子
・public:どこからでもアクセス可
・protected internal:派生クラスと同じアセンブリ内のみ
・protected:同じクラスと派生クラス内のみ
ーーーーーーーーー ↑ 公開、↓ 非公開ーーーーーーーーー
・internal:同じプロジェクト(アセンブリ)内のみ
・private protected:同じアセンブリ内の派生クラス内のみ
・private:同じクラス内のみ

■ クラスのメンバー
・データメンバー
フィールド(変数メンバー):データの入れ物。通常は private。\_をつける。
定数:不変データ
・関数メンバー
メソッド:機能
コンストラクタ:初期化時の機能
プロパティ:フィールドへアクセスする手段(getter+setter)
インデクサ:
ファイナライザ:

■ 文字コード
char 型：Unicode（UTF-16)の 16bit で表現する

■ フィールドとローカル変数
・ローカル変数: メソッド内で宣言した変数
・フィールド: クラス直下の変数, var が使えない

■ 値型と参照型
・値型: bool, int, double → 実際の値が入る
・参照型: 上記以外(string, object) → メモリアドレスが入る
・参照型は==で比較するとアドレス同士の比較になる
・参照型の中身の比較は Epuals
・配列同士の中身の比較は SequenceEqual

■null
・基本は参照型のみ null が初期値
string str = null;
・値型でも?をうしろにつけると null 許容型になる
int? num = null; Nullable<int> num = null;
・null にアクセスすると null 参照エラーになる
str.Trim();
・?を使うと null のときもエラーにならず null が返される
str?.Trim();
・null 許容型は HasValue, Value といったプロパティが使える
C#8.0 以降はデフォルトで null 禁止
・参照型でも null を使うには string?とすることが必要
（プロジェクトプロパティ → ビルド →Null 許容で設定変更）
・null 合体演算子(式 1 が null のときは式 2 を返す)
式 1 ?? 式 2;
・null 合体代入(式 1 が null のときは式 2 を式 1 に代入)
str ??= 123;

■ 配列
int[] data;
int[] data = new int[5];
int[] data = {1, 2, 3, 4, 5};
var data = new[] {1, 2, 3, 4, 5,};

■unsafe コード
・通常はメモリアクセス等のコードはエラーになる
・unsafe{}でくくってプロジェクトプロパティで有効化することで可能

■nameof 演算子
・nameof(index)とすることでメソッド名等を文字列にできる
・ActionLink 等でメソッド名変更に対応できる

■ コードメトリクス
・「分析」→「コードメトリクスを計算する」でコードの保守性が分かる
・コードメトリクスが高いほど保守性が高い

■ 重い処理(オーバーヘッドがかかるのでループ非推奨)
・try…catch
・オブジェクト生成・破壊
・文字列の結合

■ プリプロセッサディレクティブ
#define DEBUG(これはデフォルト有効なので不要)
#if DEBUG
// デバッグが定義されている時だけやる処理
#endif

■ シグニチャ
・メソッド名＋引数名のこと。

■ ジェネリック<...>
・型の異なるリスト等を同じメソッドで使えるためのもの
・一般的に Type の T を使う

class sampie<T>{
型 T を使った処理
}

■ シングルトン
・デザインパターンの 1 種
・クラスのインスタンスを 1 つしか生成したくない場合に使用
・参考:static クラスとの違い
Singleton パターン再考 static クラスは Singleton パターンに入りますか？ | cloud.config Tech Blog

■static readonly
・基本 const と同じだが、オブジェクトを定義できる。
・const と違い、中身は可変になる。

■params キーワード
可変長引数。params キーワードを引数につけることで、配列を可変長にできる。

static double GetAverage(params double[] nums)
{
double sum = 0;
foreach (var num in nums)
{
sum += num;
}
return sum / nums.Length;
}
→ GetAverage(1, 2, 3.3); // 2.1

■ref キーワード
通常は値型を引数で渡すと値のコピーが渡されるが、
ref キーワードをつけて渡すと値型の参照渡しとなりアドレスがコピーされる

int CountUp(ref int data)
{
data++;
return data;
}
→ int data = 1;
→ CountUp(ref data); // 元の引数にも影響するようになる

■in キーワード
readonly ref のこと。参照渡しをするが、中身を変更されないようにできる。

static void Show(in int c)
{
Concole.WriteLine(c);
c = 10; // これはコンパイルエラーになる
}

■out キーワード
・値を返す専用の参照渡し。ref と in と違い、引数の初期化が不要。
・引数に値が代入されないとエラーになる。

public void GetMaxMin(int x, int y, out int max, out int min)
{
if(x >= y) {max = x; min = y}
else {max = y; min = x};
}
→ GetMaxMin(3, 5, out int resultMax, out int resultMin)

■Tuple
・複数の型を()で一つまとめることができる(2 つ以上で使用可)
・主に複数値戻しに使用する
・out は戻り値が引数に設定されるため、こっちが推奨

public (int max, int min) GetMaxMin(int x, int y)
{
return x >= y ? (x, y) : (y, x);
}
→ var t = GetMaxMin(3, 5);
→ var num = t.max; // 5

・名前がない場合は Item1, Item2 でアクセス可(無名メンバー)
var x = (1, 2);
→ var a = x.Item1;

■ 匿名型
・クラスのないインスタンスを生成できる
・主に LINQ で特定オブジェクトの部分的メンバーを切り出すとき
・各プロパティは読み取り専用になるので、再代入はできない
var info = new { Title = “ほげ”, Price = 1000 };

→ var title = info.Title;

■yield return
・return の処理を終了させない版
・何個でもメソッドの中で使用できる

■ オブジェクト指向の重要キーワード
・カプセル化:使い手に関係ないものは見せない
・継承
・ポリモーフィズム

■ コードスニペット
・prop と入力して tab を 2 回押すと、プロパティのテンプレートが挿入される
・propfull で完全なプロパティ構文を挿入できる

■ インデクサー
変数名[...]の形でアクセスする仕組み

■ キャスト
・アップキャスト
Person p = new BusinessPerson();
・ダウンキャスト
BusinessPerson bp = (BusinessPerson)p;
キャストに失敗した場合はエラーになる

■is
・キャストできる場合にのみ true を返す
・ダウンキャストは失敗する可能性があるのでチェックする

if (p is Student) {  
Student st = (Student)p;
...正しくキャストできた場合の処理... }

・キャスト成功時に変数へ格納する省略構文

if (p is Student st) {  
...正しくキャストできた場合の処理... }

■as
・キャストに失敗した場合 null を返す。参照型のみ使用可

var st = p as Student;
if (st != null) {  
...正しくキャストできた場合の処理... }

■ 拡張メソッド StringExtensions
・既存のクラスにメソッドを追加できる
・static クラスの static メソッドにすること
・第 1 引数として this を付けて拡張するクラスを指定すること

internal static class StringExtensions{
public static string Repeat(this string str, int count){  
 ...メソッドの本体... }

■ ポリモーフィズム 多態性
・同じ名前のメソッドで異なる挙動を実現する

Figure t = new Triangle(10, 30);
Console.WriteLine(t.GetArea());
Figure s = new Square(10, 30);
Console.WriteLine(s.GetArea());

■virtual override
・派生クラスでメソッドを上書きできる
・new だけでも上書きできるが非推奨

■abstract 抽象メソッド
・派生クラスでメソッドのオーバーライドを強制できる
・オーバーライドしないと派生先はインスタンス化できない
・メソッド名のみを定義して中身は書かない

internal abstract class Figure {
public double Width { get; set; }
public double Height { get; set; }  
 public Figure(double width, double height) {  
 this.Width = width;  
 this.Height = height; }  
 public abstract double GetArea();
}

■interface インターフェイス
・メソッドが全て abstract のクラス
・abstract と違い、多重継承が可能
・クラスと同時に継承も可能

interface IFigure {
double GetArea();
}
internal class Triangle : MyClass, IFigure, IHoge { ～

■ 抽象クラスとインターフェイスの使い分け
・型階層の中で共通処理を持たせるなら抽象クラス
・型階層と独立して階層をまたぐならインターフェイス

■ 例外
・try, catch で書く
・例外の変数を使わない場合は書かないでもよい
・stacktrace は辿った処理を出す
・VS の［呼び出し履歴］でも見れる

try {  
 ...例外が発生する可能性があるコード... }
catch (FileNotFoundException ex) {  
 Console.WriteLine(ex.StackTrace); }  
catch (FileNotFoundException) {  
 ...例外型 2 が発生した場合の処理... }
finally {  
 // 例外の有無に関わらずやる処理 }

■ 列挙型 enum
・関連する定数群をまとめる
public enum Season{
Spring,  
 Summer,  
 Autumn,
Winter,
}

■ 構造体 struct
・値を代入するため高速
・ただし値が大きくなればオーバーヘッドも大きい
・継承はできない

■ デリケート delegate
・メソッドを変数、引数に代入できるようにする仕組み
・デリゲートと引数、戻り値が同じメソッドを代入できる
・複数メソッドを代入可(マルチキャストデリゲート)

delegate void Process(string str);
internal class DelegateBasic
{
static void Run(string s)
{
Console.WriteLine($"{s}走ります。");
}
static void Main(string[] args)
{
var p = new Process(Run);
p("ちょこちょこ");
}  
}

```
delegate void OutputProcess(string str);
internal class DelegateUse
{
  void ArrayWalk(string[] data, OutputProcess output) {
    foreach (var value in data)
    {
      output(value);
    }
  }
  static void AddQuote(string data)
  {
    Console.WriteLine($"[{data}]");
  }
  static void Main(string[] args)
  {
    var data = new[] { "あかまきがみ", "あおまきがみ" };
    var du = new DelegateUse();
    OutputProcess proc = AddQuote;
    du.ArrayWalk(data, proc);
  }
}
```

■ 匿名メソッド
・名前を持たないメソッド
・デリゲートのメソッドは使い捨てなので省略するために使う

dm.ArrayWalk(data, delegate(string d) {
return $"［{d}］";
});

■Func デリゲート
・ライブラリにあるジェネリックデリケート

public delegate TResult Func<in T, out TResult>(T arg)

■ ラムダ式
・匿名のさらに省略記法

```
dl.ArrayWalk(data, (d) =>  $"［{d}］" );
```

■LINQ
・基本的に遅延実行。即時実行したい場合は ToList()等をつける。
・クエリ構文: メソッド構文の簡素表現。全てには対応してない

```
var sample = from b in AppTables.Books
                        where b.Price > 1000
                        select b.Title;
```

・メソッド構文: 全てに対応。

```
var hoge = AppTables.Books
                    .Where(b => b.Price > 1000)
                    .Select(b => b.Title);
```

■ マルチスレッド処理
・スレッド: プログラムを実行する処理の最小単位。メモリ空間を共有しながら処理だけを分離する。
・プロセス: スレッドの集まり。プログラムのインスタンスそのもの。CPU とメモリが個別に割り当てられる。
・シングルスレッド: 既定でアプリが動作する、メインスレッドのみでの処理。
・マルチスレッド: 複数スレッドを並行実行する仕組み。

・注意点: マルチスレッドはデータを共有する場合に同時アクセスを意識する必要がある。

■ スレッドの生成/実行 Thread
・Thread クラスでスレッドを新たに生成/実行できる(非推奨)
var t1 = new Thread(Count); // delegate
t1.Start(); // スレッド開始
t1.Join(); // スレッド終了までメインスレッドを待機

■ タスク Task
・スレッドプール: 生成したスレッドを保持しておいて再利用する仕組み
→ オーバーヘッド軽減
・タスク: スレッドプールの利用を伴うスレッド

Task t1 = Task.Run(() => Count(1)); // タスク開始
t1.Wait(); // タスク終了まで待機
Task.WaitAny(t1, t2, t3); // いずれか終了まで待機
Task.WaitAll(t1, t2, t3); // 全て終了まで待機

■ 排他制御

■ 属性
・自作方法なぞ

■ リフレクション

■dynamic 型
・動的型付け。Python 等の実行に役立つ

■JSON
・newtonsoft.json を使う

■ イベント
・

■C# Interactive
・VS のコマンドライン上でコンパイルなしで実行できる

## 勉強

### 独習 C# 山田祥寛

1 周目: 2023/06/25(土)～ 2023/09/24(金)
