// WebApplicationBuilderのインスタンスを生成する
// 引数でアプリ名や環境名を指定できる
var builder = WebApplication.CreateBuilder(args);

// MVCのサービスを追加する
// AddControllersWithViewsは、コントローラとビューの両方をサポートする
// AddControllersは、コントローラのみをサポートする
// AddRazorPagesは、Razor Pagesをサポートする
builder.Services.AddControllersWithViews();

// WebApplicationのインスタンスを生成する
var app = builder.Build();

// 開発環境でなければ
if (!app.Environment.IsDevelopment())
{
    // デフォルトのエラーページの設定
    app.UseExceptionHandler("/Home/Error");
    // HSTS: HTTP Strict Transport Security
    // レスポンスにStrict-Transport-Securityヘッダーを追加し以降の通信をHTTPSに強制
    app.UseHsts();
}

// HTTPリクエストをHTTPSにリダイレクトする
app.UseHttpsRedirection();
// ルーティングのミドルウェアを追加
app.UseRouting();
// 認可のミドルウェアを追加
app.UseAuthorization();
// 静的ファイルのルーティングを追加
app.MapStaticAssets();

// Controllerルーティングの設定
app.MapControllerRoute(
    name: "default", // ルート名
    pattern: "{controller=Home}/{action=Index}/{id?}") // ルートパターン
    .WithStaticAssets(); // 静的ファイルのルーティングを追加

// ルートの簡易設定
// app.MapGet("/", () => "Hello World!");

app.Run();
