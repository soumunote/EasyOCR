# EasyOCR
指定されたフォルダ内にある画像ファイルをスキャンし、文字情報を抽出する。  
AI を利用した一般的な OCR ツールのように、やみくもに文字列を探し出して文字起こしは行わない。
指定した座標に存在する文字を狙い撃ちでスキャンする、どちらからかというと業務利用を想定する。

## 利用方法
0. 事前準備として、スキャンしたい文字座標を設定しておく  
   (作者の体力が無いため、設定ファイルは現状手打ち)
1. SnapScan 等を利用し、大量の文書をスキャンし特定のフォルダに画像ファイルを格納する
   同じレイアウトの文書に限る
2. 本プログラムで、スキャンを行う
--
MITライセンスとしますが、もしも
- 参考にした
- そのままコンパイルして利用した
- 全然ダメだ...
等、作者の励みのために、issue にご一報頂きたいです。  
そもそも、このリポジトリを誰かがみてくれているかさえわからないので...

## 更新履歴
0.1 作っただけ

## 参考にさせて頂いたサイト
- [GAMMASOFT Tesseract OCR を　Windows　にインストールする](https://gammasoft.jp/blog/tesseract-ocr-install-on-windows/)  
- [GAMMASOFT Python で OCR を実行する方法](https://gammasoft.jp/blog/ocr-by-python/)  
- [日本語 OCR による文字認識 〜 WPF などの .NEt Framework アプリや UWP アプリから Windows 10 の OCR エンジンを使う](https://codezine.jp/article/detail/10748?p=3)