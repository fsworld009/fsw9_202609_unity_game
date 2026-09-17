# 2026年度 Unity授業 前期課題 3Dシューティングゲーム

![Screenshot](screenshot.png)


## 目次

1. [ゲームの目的](#ゲームの目的)
2. [操作](#操作)
3. [ソースコードについて](#ソースコードについて)

## ゲームの目的

1. 敵を倒してスコアを集める
2. ゴールポイントに到着

## 操作

|アクション | キーボード　| マウス | コントローラー(Xbox配置)|
|---------|-----------|-------|----------------------|
|移動     | WASD       | (なし)| 左スティック、十字キー |
|ジャンプ　| SPACE      | (なし)| A|
|回転     | J, L       |マウス移動   | LBとRB、或いは右スティック |
|弾を撃つ|   K         | 左クリック | X|

## ソースコードについて

### 外部アセット

このプロジェクトはUnityアセットストアから以下の外部アセット利用しています。
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