JOKER SCRIPT ｜ジョーカースクリプト　Ver0.4.1（C）STRIKEWORKS / ShikemokuMK

http://jokerscript.jp


■使い方■

公式ページにチュートリアルとタグリファレンスがありますので参考にしてください

【タグリファレンス】
http://jokerscript.jp/home/tag

【使い方＆チュートリアル】
http://jokerscript.jp/usage/tutorial/about


■利用規約■

ジョーカースクリプトは
個人利用において、商用・非商用問わず、無料で利用することが可能です。
法人での利用にも制限はありません。

著作権はシケモクMKが所持します。
ジョーカースクリプト自体を改変しての再配布は禁止します。
ただし、ゲームとして利用する用途に限り改変を認めます。
　
■免責事項■

本ツールを利用したことによって損害・不利益・事故等が
発生した場合でも、一切の責任を負いません。


■連絡先■

メール
shikemokumk@gmail.com

Twitter
http://twitter.com/shikemokumk


■謝辞■
以下の素材を利用させて頂きました。

ぴたちー素材館　様
http://www.vita-chi.net/sozai1.htm

DOVA SYNDROME 様
http://dova-s.jp/

SUGAR STAR 様
http://sgst.x.fc2.com/sozai/sozai_base.htm

ティラノユーザー会

■主な更新履歴■

V0.4.1 (2015/12/20)
Unity5.2対応
文字周りのバグ修正

V0.4.0 (2015/10/30)
Unity5.2対応

V0.3.0 (2015/5/6)
Unity5.0対応

V0.2.0 (2015/2/20)
uGUI対応
Live2D正式サポート
動作高速化

V0.0.3 (2014/12/20)
Unity4.6に対応
縦画面のゲームに対応
細かいバグ修正

V0.0.2 (2014/12/4)
安定化対応。

V0.0.1 (2014/10/17)
実験版リリース！

---------------------------------------------------------------------


ごていじゅうさんたいでもわかるじょーかーすくりぷとのつかいかた

♦♦♦♦Q.一体どうやって導入すればいいんだ！！！！♦♦♦♦

①導入したいプロジェクトを開く
②fileからopen sceneを選びJOKERを選ぶ


♦♦♦♦Q.一体どうやって文字を表示させればいいんだ！！！！♦♦♦♦


①プロジェクトフォルダのscenarioフォルダをひらーく（JOLER_GAME>Resources>novel>data>と下っていけばいい）

②「wide」と「tall」という２つのフォルダがあーる。
wide = ヨコ型のゲーム
tall = タテ型のゲーム

③この中の scene1 というファイルがあーる。（初期状態の場合）

④scene1の上で右クリックをして、Reveal in Finder　をえらーぶ。

⑤scene1の中身をかーく。

基本的なタグ一覧

※タグは文章の末尾につけること

[l]
クリック待ち

[r]
改行

[p]
改ページ

[wait time=〇〇]
〇〇秒間処理を止める

＃
主に名前表示に使用


♦♦♦♦　Q.一体どうやって背景を表示させればいいんだ！！！！♦♦♦♦

①適当な画像を用意しよう

②porojectのimage/backgroundフォルダにぶちこもう

③scenarioフォルダから該当するテキストファイルを開いて

;背景の新規定義
[bg_new storage="名前"]

;背景の表示
[bg_show ]

これをwaitの前に挿入するだけだ。

[bg_new]で背景を定義して[bg_show]で表示するわけだ！

④既存の背景から別の背景に変えたいときは

[bg_mod storage="〇〇"]

で変更が可能だ！！
さらに[bg_mod storage="〇〇"time=〇〇]
で画面の切り替わりの時間も指定ができるぞ！！

♦♦♦♦　Q.一体どうやってキャラを表示させればいいんだ！！！！♦♦♦♦

①画像images/characterにぶちこむ

②キャラクターの宣言をする
[chara_new name=yuko storage=名前 scale="大きさの倍率(無くても良い)"jname = ディスプレイ名 jcolor="色コード"]

[chara_new]の時に jname　というパラメータにキャラクター名 
そして、jcolorに色を設定しておくと 
シナリオ中にシャープを先頭につけてname属性を指定することで
紐づく日本語名と色を表示することができる

③キャラクターを表示する
[show name=名前]

♦♦♦♦　Q.一体どうやって音楽を鳴らせばいいんだ！！！！♦♦♦♦

①プロジェクトのbgmフォルダにぶち込む

②[playbgm storage=〇〇]で音楽を再生

③[stopbgm]で停止

④[playse storage=〇〇]で効果音

⑤[stopse]で効果音停止
