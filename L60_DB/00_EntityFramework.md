# EntityFramework

- [EntityFramework](https://learn.microsoft.com/ja-jp/ef/)
  - C#の O/R マッパー
  - LINQ 使用可能
  - スキーママイグレーション可能

## インストール

- `dotnet tool install --global dotnet-ef`
  - EntityFramework のインストール
- `dotnet ef --version`
  - バージョン確認
- `dotnet tool update -g dotnet-ef`
  - アップデート

## 任意

- `dotnet tool install --global dotnet-aspnet-codegenerator`
  - スキャフォールディング機能のコマンドラインツール

## ライブラリ

- [Microsoft.EntityFrameworkCore.Design](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design)
  - スキャフォールディング機能を実行するためのツール群
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools)
  - EF Core 関連のコマンドを実行するためのツール群
- [Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design)
  - ASP.NET Core のコード生成のためのライブラリ

## DB ごと

- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer)
  - SQL Server
- [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite)
  - SQLite

## コマンド

-

- `dotnet ef database update`
  - マイグレーションファイルの内容で DB 更新する
