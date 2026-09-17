# 2026年度 Unity授業 前期課題 3Dシューティングゲーム

![Screenshot](screenshot.png)



## 目次

1. [提出課題の説明](#提出課題の説明)
2. [ゲームのダウンロード](#ゲームのダウンロード)
3. [ゲームの目的](#ゲームの目的)
4. [操作](#操作)
5. [ソースコードについて](#ソースコードについて)

## 提出課題の説明

ルートB：お題「3Dシューティング」のゲームです。

お題のチェックリストを全部達成しました：
- プレイヤーがWASDで動く
- 弾が敵に当たって倒せる
- 敵がプレイヤーを追ってくる
- BGM・効果音が鳴る
- カメラがプレイヤーを追う
- タイトル→プレイ→リザルトの流れ
- マウスクリックで弾を撃つ
- 敵が複数スポーンする
- スコア・HP が画面に表示される
- キャラがアニメーションする
   - 追ってくる敵の移動アニメーション、キャラクターの点滅エフェクト
- 敵撃破で爆発エフェクト

他の実装した要素：

- UnityのInputSystemでキーボード、マウス、コントローラーの入力同時対応
- プレイヤーのジャンプアクション
- プレイヤーがダメージ受けた時のノックバックアニメーションと一時的に操作不能の制限
- プレイヤーがダメージ受けた後の無敵時間と点滅エフェクト
- 敵種類一体追加：左右移動とを弾撃つことができる
- プレイヤーのHPゲージの表示
- 敵のHPゲージの表示
- 壁がカメラの前に立った時に半透明になる

## ゲームのダウンロード

[Releases](https://github.com/fsworld009/fsw9_202609_unity_game/releases)ページからダウンロードしてください。

## ゲームの目的

1. 敵を倒してスコアを集める
2. ゴールポイントに到着

## 操作

|アクション | キーボード　| マウス | コントローラー(Xbox配置)|
|---------|-----------|-------|----------------------|
|移動     | WASD       | (なし)| 左スティック、十字キー |
|ジャンプ　| SPACE      | (なし)| A|
|回転     | J, L       |マウス移動   | LBとRB、或いは右スティック |
|弾を撃つ<br>(押しっぱなし：連射) |   K         | 左クリック | X|

## ソースコードについて

### 外部アセット

このプロジェクトはUnityアセットストアから以下の無料アセット利用しています。
アセットストアのアセットはリポジトリに直接にコミットできないため、ご自身のパソコンにこのプロジェクトをチェックアウトする場合、自力で以下のアセットをダウンロードし、プロジェクトにインポートする必要があります。

- [Particle Collection SKJ 2016_Free samples](https://assetstore.unity.com/packages/vfx/particles/particle-collection-skj-2016-free-samples-72399)
  - **`Plugins`と`Scene`フォルダをインポートしないでください**。するとスクリプトエラーになります
- [ShootingSound](https://assetstore.unity.com/packages/audio/sound-fx/shooting-sound-177096)
  - 必要なファイル：`cannon_01.wav`, `laser_01.wav`
- [FREE SOUND COLLECTION](https://assetstore.unity.com/packages/audio/sound-fx/free-sound-collection-291913#content)
  - 必要なファイル：
    - Musical Instruments(16)
      - `Cymbals-008.wav`
    - Retro(52)
      - `ExplodeBip1.wav`
      - `hit_explosion-2.wav`
      - `hit_explosion-3.wav`
      - `Jump-003.wav`
- [Action RPG Music Free](https://assetstore.unity.com/packages/audio/music/action-rpg-music-free-85434#content)
  - 必要なファイル：
    - `BGM04town0.wav`
    - `BGM14chase.wav`
    - `MS01triumph1NL.wav`
    - `MS02gameover2V1NL.wav`