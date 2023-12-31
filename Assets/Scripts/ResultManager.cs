using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    //このクラスの役割
    //３問回答を終えたらResultシーンへ切り替え
    //スコアに応じた結果を画面に表示

    public int resultScores;//ゲームディレクタークラスのスコアを受け取る
    public Text resultRank;//スコアに応じたランク
    public string rank;
    public Text resultComment;//ランクごとのコメント
    public string comment;
    public Image resultImage;
    public Sprite reImage;
    public Sprite resultImageS;//結果ごとの表示画像
    public Sprite resultImageA;//結果ごとの表示画像
    public Sprite resultImageB;//結果ごとの表示画像
    public Sprite resultImageC;//結果ごとの表示画像
    public Sprite resultImageD;//結果ごとの表示画像

    public void setResultImage()
    {
        //resultImageS.SetActive(true);
    }

    //resultRunk判定メソッド
    public void JudeResultRunk()
    {
        if(this.resultScores == 100)
        {
            rank = "S";
            comment = "サンタさんもにっこり";
            reImage = resultImageS;
            
        }
        else if(this.resultScores >= 76)
        {
            rank = "A";
            comment = "サンタさんには会えたかな?";
            reImage = resultImageA;
        }
        else if(this.resultScores >= 51)
        {
            rank = "B";
            comment = "おしい！もう少し";
            reImage = resultImageB;
        }
        else if(this.resultScores >= 26)
        {
            rank = "C";
            comment = "子供が一番ほしいプレゼントはどれかな？";
            reImage = resultImageC;
        }
        else if(this.resultScores >= 0)
        {
            rank = "D";
            comment = "もう一度チャレンジしてみよう!!";
            reImage = resultImageD;
        }
        this.resultRank.text = rank;
        this.resultComment.text = comment;
        this.resultImage.sprite = reImage;
    }

    // Start is called before the first frame update
    void Start()
    {
        resultScores = GameDirector.scores;//ゲームディレクタークラスのスコアを受け取る
        //resultScores = 50;//デバック用
        JudeResultRunk();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
