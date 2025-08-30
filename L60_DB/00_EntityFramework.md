# EntityFramework

- [EntityFramework](https://learn.microsoft.com/ja-jp/ef/)
  - C#の O/R マッパー
  - LINQ 使用可能
  - スキーママイグレーション可能

## dotnet-ef コマンドツール

- `dotnet tool install --global dotnet-ef`
  - EntityFramework のインストール
- `dotnet ef --version`
  - バージョン表示
- `dotnet tool update -g dotnet-ef`
  - アップデート
- `dotnet tool list --global`
  - インストールされている tool リスト表示

## 基本ライブラリ

- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools)
  - EF Core 関連のコマンドを実行するためのツール群

## DB ごとのライブラリ

- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer)
  - SQL Server
- [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite)
  - SQLite
- [Pomelo.EntityFrameworkCore.MySql](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql)
  - MySQL
- [Npgsql.EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL)
  - PostgreSQL

## マイグレーションファイル作成

- `dotnet ef migrations add InitialMigration`
  - マイグレーションファイルの作成

## DB 更新

- `dotnet ef database update`
  - マイグレーションファイルの内容で DB 更新する
