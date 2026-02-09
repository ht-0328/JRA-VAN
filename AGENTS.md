# AGENTS.md

このディレクトリ以下のコードベースで作業するAIエージェント（Jules等）への包括的な指示書です。
すべてのコード生成、リファクタリング、設計提案は本ドキュメントに従ってください。

## 1. プロジェクト概要
- **目的**: JRA-VAN Data Lab API (JV-Link) を使用して中央競馬のデータを取得し、自前のデータベースに蓄積する「競馬データ収集・解析基盤」の構築。
- **アプリケーション形態**: コンソールアプリケーション (Console App)。Web APIではありません。
- **ターゲット**: .NET 10 (C# 14) / Windows OS (JV-Linkの制約による)。

## 2. 技術スタックとアーキテクチャ
### 技術選定
- **言語**: C# 14 (.NET 10)
- **データアクセス**: Dapper (軽量・高速化のためEF Coreは使用しない)
- **DB**: PostgreSQL
- **SDK**: JRA-VAN JV-Link (COM/ActiveX)
- **DI**: Microsoft.Extensions.DependencyInjection (必要最低限)

### アーキテクチャ: モジュラーモノリス
機能（ドメイン）ごとにディレクトリを切って管理します。

src/
  ├── Modules/
  │   ├── Race/          # レース情報に関する処理
  │   ├── Horse/         # 競走馬に関する処理
  │   └── Odds/          # オッズに関する処理
  ├── Shared/
  │   ├── JraVan/        # JV-Linkとの通信制御 (低レイヤー)
  │   └── Database/      # DB接続・共通SQL処理
  └── Program.cs         # エントリーポイント

## 3. 【最重要】JRA-VAN API 実装上の絶対制約
JV-LinkはレガシーなCOMコンポーネントです。**以下のルールを無視した「モダンなリファクタリング」は厳禁です。**

1. **JVGetsのシグネチャ変更禁止**:
   - `JVGets` メソッドには必ず `ref object` 型でバッファを渡すこと。
   - `ref byte[]` や `ref string` に書き換えてはならない。
   - `object buffObj = byteBuffer;` のボクシング処理を削除してはならない。
2. **固定長バイト配列の維持**:
   - データパースは `Shift_JIS` エンコーディングを使用し、バイト位置指定で行うこと。
   - 文字列操作（Substring等）でパースしようとしないこと（全角半角でバイト数がズレるため）。
3. **STAスレッドの確保**:
   - ActiveXコンポーネントのため、実行スレッドは `[STAThread]` 属性、または `ApartmentState.STA` である必要がある。

## 4. コーディング規約
- **言語設定**:
  - コード内のコメント、ドキュメントはすべて **日本語** で記述する。
  - 変数名・クラス名は英語（PascalCase / camelCase）とする。
  - Pull Requestのタイトル、説明、コミットメッセージは **日本語** とする。
- **SQL処理**:
  - 複雑なクエリビルダは使わず、Raw SQL を `Dapper` で実行するスタイルを基本とする。
  - SQLインジェクション対策のため、必ずパラメータ化クエリを使用すること。

## 5. 開発プロセス
- **Issue駆動**: 作業は必ずIssueに基づいて行い、Issueの要件を満たす実装を行うこと。
- **スコープ**: 「やること」と「やらないこと」を明確にし、過剰なエンジニアリングを避けること。

## 6. 参照ドキュメント
- JV-Data仕様書 (データ定義): https://jra-van.jp/dlb/sdv/sdk/JV-Data4901.pdf
- JV-Link仕様書 (API定義): https://jra-van.jp/dlb/sdv/sdk/JV-Link4901.pdf
- DataLab仕様書 (全般): https://jra-van.jp/dlb/sdv/sdk/DataLab422.pdf
