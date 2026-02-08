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

# JRA-VAN API 実装ルールと公式リファレンス

## 1. 参照すべき公式ドキュメント
AIエージェントは以下の仕様書を正として実装してください。
- JV-Data仕様書 (データ定義): https://jra-van.jp/dlb/sdv/sdk/JV-Data4901.pdf
- JV-Link仕様書 (API定義): https://jra-van.jp/dlb/sdv/sdk/JV-Link4901.pdf
- DataLab仕様書 (全般): https://jra-van.jp/dlb/sdv/sdk/DataLab422.pdf

## 2. JVOpenメソッドの第一引数のルール (最重要)
JVOpenの第一引数（dataspec）には、絶対にレコードID（"RA"や"SE"など）を直接渡してはいけません。
必ず以下の「データ種別キー」を渡してください。

- 正しい指定: "RACE"
  （解説: これを指定すると、RA, SE, UM, KS, CH が順番に取得できます）

- 正しい指定: "DIFF"
  （解説: これを指定すると、WH, O1, WE が取得できます）

- 間違った指定: "RA"
  （解説: これを渡すとエラーコード -111 が発生します）

## 3. エラーコード -111 の対処法
実行時に「戻り値 -111」が出た場合は、JVOpenの第一引数が間違っています。
コード内で "RA" などを指定している箇所を探し、必ず "RACE" に修正してください。

## 4. レコードの判定
データはバイト配列で返ってきます。
先頭2バイトの文字を見て、どのクラス（RA型かSE型か）にマッピングするかを分岐してください。
