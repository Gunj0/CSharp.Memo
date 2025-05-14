# DB 接続

【環境】
Visual Studio
C# + .NET Framework
ASP.NET MVC

【手順】
■ エンティティ(データモデル)を定義する
Model フォルダに以下のようなクラス(POCO)を作成
namespace Project.Models
{
public class Member // Members テーブルにマッピングされる
{
public int Id { get; set; }
public string Name { get; set; }
}
｝

■NuGet インストール
.NET Framework の場合
「EntityFramework」をインストール

■ コンテキストクラスを定義する
Model フォルダに DB 接続の橋渡しをするクラスを作成
using System.Data.Entity;
namespace Project.Models
{
public class BasicContext : DbContext
{
public DbSet<Member> Members { get; set; }
}
}

■Context に対する DB 接続文字列を定義
Web.config に以下を定義
// name:context クラス名、Data Source:SQL Server ホスト名
// AttachDbFilename:DB ファイルパス、|DataDirectory|:App_Data のこと
// Integrated Security:True で Windows 認証、False で SQL Server 認証
<configuration>
<configSections>

<!-- configSectionsは先頭である必要がある -->
</configSections>
<connectionStrings>
<add name="BasicContext"
						 connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=BasicContext;AttachDbFilename=|DataDirectory|\Basic.mdf;Integrated Security=True"
						 providerName="System.Data.SqlClient" />
</connectionStrings>
</configuration>

■(任意)イニシャライザにテストデータをセット
起動時の確認のため、イニシャライザをオーバーライド
namespace Project.Models
{
// DB が存在しなければ作成する
public class Initializer : CreateDatabaseIfNotExists<BasicContext>
{
protected override void Seed(BasicContext context)
{
var members = new List<Member>
{
new Member
{
MemberId = 1,
Name = "ほげ",
},
};
members.ForEach(m => context.Members.Add(m));
context.SaveChanges();
}
}
}

■ イニシャライザをセット
Global.asax に以下を追加
// テストデータ不要の場合、Initializer の代わりに
// CreateDatabaseIfNotExists<BasicContext>等をセットしてもよい
protected void Application_Start()
{
Database.SetInitializer<BasicContext>(new Initializer());
}

■ コントローラで受渡し
using Project.Models;
namespace Project.Controllers
{
public class DefaultController : Controller
{
private BasicContext db = new BasicContext();

    		public ActionResult Index()
    		{
    			return View(db.Members);
    		}
    	}
    }

■ ビューで表示
@model IEnumerable<Project.Models.Member>
@foreach (var item in Model)
{
@item.MemberId
@item.Name
}

■DB 確認
全てのファイルを表示して App_Data 内の mdf ファイルを開く
→ サーバーエクスプローラーからテーブル定義やデータが表示できる
■ 発行 SQL の確認
コントローラのコンストラクタにロギングを追加すると出力で確認できる
using Project.Models;
using System.Diagnostics;
public class DefaultController : Controller
{
private BasicContext db = new BasicContext();
public DefaultController()
{
db.Database.Log = sql =>
{
Debug.Write(sql);
};
}
}

【個別のアカウント認証の場合】
■ プロジェクト新規作成
認証の種類： 個別のアカウント
☑HTTPS 用の構成
🔲Docker を有効にする
🔲Do not use top-level statements
この時点で、appsettings.json に以下の接続文字列が記載されている
{
"ConnectionStrings": {
"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-Moritani.Hikaku.Web-8363B977-348E-4077-A249-83AD487BE685;Trusted_Connection=True;MultipleActiveResultSets=true"
},
}

【メモ】
・オブジェクト指向言語のオブジェクトモデルとリレーショナル DB のテーブルモデルとの間には
構造的ギャップ(インピーダンスミスマッチ)がある
→O/R(Object/Relational)マッピングにより双方向に変換する O/R マッパーを使う
→ 概念モデル(Entity)+論理モデル(リレーショナルモデル)=Entity Data Model(EDM)
