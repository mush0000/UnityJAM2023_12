using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Result : MonoBehaviour
{
    //このクラスの役割
    //３問回答を終えたらResultシーンへ切り替え
    //スコアに応じた結果を画面に表示

    public int resultScores;//ゲームディレクタークラスのスコアを受け取る
    public string resultRunk;//スコアに応じたランク
    public string resultComment;//ランクごとのコメント
    public Sprite resultImage;
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
            resultRunk = "S";
            resultComment = "サンタさんもにっこり";
            resultImage = resultImageS;
        }
        else if(this.resultScores >= 76)
        {
            resultRunk = "A";
            resultComment = "サンタさんには会えたかな?";
            resultImage = resultImageA;
        }
        else if(this.resultScores >= 51)
        {
            resultRunk = "B";
            resultComment = "おしい！もう少し";
            resultImage = resultImageB;
        }
        else if(this.resultScores >= 26)
        {
            resultRunk = "C";
            resultComment = "子供が一番ほしいプレゼントはどれかな？";
            resultImage = resultImageC;
        }
        else if(this.resultScores <= 0)
        {
            resultRunk = "D";
            resultComment = "もう一度チャレンジしてみよう!!";
            resultImage = resultImageD;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        resultScores = GameDirector.scores;//ゲームディレクタークラスのスコアを受け取る
        JudeResultRunk();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
