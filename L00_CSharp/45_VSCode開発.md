# VSCode 開発

## 拡張機能

- 必須
  - C# Dev Kit (Microsoft)
    - C#開発の基本ツール, デバッグ等
  - C# (Microsoft)
    - C# の基本言語サポート(C# Dev Kit に付随してくる)
  - .NET Install Tool (Microsoft)
    - SDK と Runtime をインストール/管理する(C# Dev Kit に付随してくる)
  - IntelliCode for C# Dev Kit (Microsoft)
    - C#コード補完ツール
- 任意
  - C# Extensions (JosKreativ)
    - 右クリックでクラスファイル等を追加できる
  - NuGet Gallery (pcislo)
    - 統合ターミナルで NuGet が GUI 操作できる

## デバッグ

- 1 つ目のプロジェクト
  - `Ctrl + Shift + P`→`.Net: Generate Assets for Build and Debug`
    - .vscode/launch.json, tasks.json が作られる
  - tasks.json
    - `"label":"build"`→`"label":"build_ConsoleApp"`に変える
  - launch.json
    - `"name": ".NET Core Launch (console)"`→`"name": ".NET Core Launch (console)_ConsoleApp"`に変える
    - `"preLaunchTask": "build"`→`"preLaunchTask": "build_ConsoleApp",`に変える
- 2 つ目のプロジェクト
  - `Ctrl + Shift + P`→`.Net: Generate Assets for Build and Debug`
    - .vscode/launch.json, tasks.json が作られる(置き換えますか？の警告は OK)
- これで、VSCode のデバッグタブからデバッグ対象を切り替えられるようになる

## NuGet

- C# Dev Kit の場合
  - `Control + Shift + P`→`NuGet: NuGet パッケージを追加`
- NuGet Gallery の場合
  - `Control + J`の NUGET タブで GUI 操作する

## 参考

- [dotnet コマンド](https://learn.microsoft.com/ja-jp/dotnet/core/tools/dotnet)
- [[C#]VSCode で複数プロジェクトを持つソリューションを作るときの備忘録](https://qiita.com/unyorita/items/8a92cb19b618e8e4a4a5)
- [VSCode と dotnet-cli で C#のソースコードをテスト出来るようにするまで](https://qiita.com/jnuank/items/e9aeb2d8c99d1e6f1081)
- [C#でドメイン駆動開発パート１【C#でドメイン駆動開発とテスト駆動開発を使って保守性の高いプログラミングをする方法】](https://yayoi-kkjp.udemy.com/course/domain-1/)
