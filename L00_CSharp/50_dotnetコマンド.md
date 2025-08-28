# dotnet コマンド

## ソリューションファイル 作成

```bash
dotnet new sln -o CSharp.Memo
```

## テンプレート確認

```bash
dotnet new list
```

- [テンプレート一覧](https://learn.microsoft.com/ja-jp/dotnet/core/tools/dotnet-new)
  - sln: ソリューション
  - gitignore: .gitignore
  - console: コンソールアプリ
  - classlib: クラスライブラリ
  - mvc: ASP.NET Core Web MVC アプリ
  - webapi: ASP.NET Core Web API
  - mstest: MSTest
  - webconfig: Web 構成

## プロジェクトテンプレート作成

```bash
dotnet new console -o ./L00_CSharp
# -o で出力先(プロジェクト名)指定
# --no-https でHTTPS無効化
```

## プロジェクトをソリューションに追加・削除・リスト表示

```bash
dotnet sln add L00_CSharp
dotnet sln remove L00_CSharp
dotnet sln list
```

## プロジェクト参照追加

- `dotnet add {参照する側Path} reference {参照される側Path}`
  - プロジェクト参照を追加する
- `dotnet remove {参照する側Path} reference {参照される側Path}`
  - プロジェクト参照を削除する

## ビルド

- `dotnet build`
  - bin と obj が作られる

## アプリ起動

- `dotnet watch`
  - プロジェクトフォルダ配下でアプリ起動
  - Hot reload 状態

## デバッグ起動

- `dotnet run`
  - ターミナルで実行結果が返る
  - もしくは F5

## HTTPS 有効化

```bash
# 自己署名証明書の発行 https://learn.microsoft.com/ja-jp/dotnet/core/tools/dotnet-dev-certs
dotnet dev-certs https --trust

# https起動
dotnet watch --launch-profile https
```

## .NET バージョン確認

- [.NET の最新バージョン](https://dotnet.microsoft.com/ja-jp/download)
- `dotnet --version`
  - 使用されている.NET SDK バージョン
- `dotnet --list-sdks`
  - インストールされている.NET SDK バージョン一覧
- `dotnet --list-runtimes`
  - インストールされている.NET ランタイム一覧
- `dotnet --info`
  - 環境情報などの詳しい情報

## テスト

- `dotnet test`
  - テスト実行される
  - もしくは VSCode のテストタブから実行できる
