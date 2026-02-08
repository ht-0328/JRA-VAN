# AGENTS.md

このディレクトリ以下のコードベースで作業するAIエージェントへの指示書です。

## プロジェクト概要
このプロジェクトは、JRA-VANの競馬データ取得用COMコンポーネント「JV-Link」を使用するC#コンソールアプリケーションです。
元のモノリシックな構造から、保守性と拡張性を考慮したアーキテクチャにリファクタリングされています。

## 技術スタック
- **フレームワーク**: .NET 8 (Console App)
- **エンコーディング**: Shift-JIS (`System.Text.Encoding.CodePages`)
- **外部依存**: JRA-VAN JV-Link (COMコンポーネント)

## アーキテクチャ
プロジェクトは以下のレイヤーで構成されています。

1.  **Infrastructure (`JRA-VAN/Infrastructure/`)**
    -   `JraVanClient`: JV-Link COM操作のカプセル化（初期化、データ取得、リソース解放）。
    -   `JvRecordMapper`: バイト配列からC#オブジェクトへのマッピングを担当。
    -   `JvRecordAttribute`: マッピングルール（オフセット、長さ）を定義する属性。

2.  **Models (`JRA-VAN/Models/`)**
    -   `RaRecord` などのデータモデル（DTO）。`[JvField]` 属性を使用して定義します。

3.  **App (`JRA-VAN/Program.cs`)**
    -   エントリーポイント。`JraVanClient` を使用してデータを取得し、処理します。
    -   `verify` 引数によるマッピングロジックの単体検証機能を持ちます。

## コーディング規約
1.  **コメント言語**:
    -   コード内のコメント、XMLドキュメントコメントは**日本語**で記述してください。
    -   ただし、ライブラリ名や固有名詞（例: `JVLink`, `Shift_JIS`）は英語表記で構いません。

2.  **エラーハンドリング**:
    -   JV-Linkの戻り値をチェックし、異常時は `JraVanException` をスローしてください。

3.  **環境制約**:
    -   開発・テスト環境（Linux等）ではCOMコンポーネントが動作しない場合があります。
    -   ロジックの検証には `Program.cs` の `VerifyMapper` メソッド（`verify` 引数）を使用するか、モックを活用してください。
