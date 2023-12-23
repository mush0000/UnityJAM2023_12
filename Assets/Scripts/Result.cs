using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    //このクラスの役割
    //３問回答を終えたらResultシーンへ切り替え
    //スコアに応じた結果を画面に表示

    public int resultScores;//ゲームディレクタークラスのスコアを受け取る
    public string resultRunk;//スコアに応じたランク
    public string resultComment;//ランクごとのコメント

    //resultRunk判定メソッド
    public void JudeResultRunk()
    {
        if(this.resultScores == 100)
        {
            resultRunk = "S";
            resultComment = "サンタさんもにっこり";
        }
        else if(this.resultScores >= 76)
        {
            resultRunk = "A";
            resultComment = "サンタさんには会えたかな?";
        }
        else if(this.resultScores >= 51)
        {
            resultRunk = "B";
            resultComment = "おしい！もう少し";
        }
        else if(this.resultScores >= 26)
        {
            resultRunk = "C";
            resultComment = "子供が一番ほしいプレゼントはどれかな？";
        }
        else if(this.resultScores <= 0)
        {
            resultRunk = "D";
            resultComment = "もう一度チャレンジしてみよう!!";
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
