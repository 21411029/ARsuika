# ARsuika
ARでスイカ割り体験

# タブレット側のプロジェクト
- 棒の表示
- スイカの表示
- パラメータ転送
- マーカの解釈

プレーヤ検出などは https://github.com/21411029/ARsuika-kinect で行う。

# 開発環境

AndroidSDK 最新版を入れると、Unity から android.bat コマンドが発行できなくなっていて、ハマる。

http://dl-ssl.google.com/android/repository/tools_r25.2.5-windows.zip　から、ダウングレード用のツールを落とし、AndroidSDK フォルダの tools フォルダを入れ替えると、救われる。

# Devices

- Tegra Note = 5.1
- Asus Notepad = 4.2.2
- Takagi Note = 4.0.4
- Asus TF201 = 4.1.1

# Version
- Vuforia ~~6.0.117~~ 6.2.10 （Extended Tracking を利用。これは効く）
- Unity 5.3.5f1
- Kinect2 ???
