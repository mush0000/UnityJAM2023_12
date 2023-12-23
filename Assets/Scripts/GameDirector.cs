using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //このクラスの役割
    //リストから問題を３問選んで格納
    //スコアを保存(シーン切り替えても消えないように)

    // メンバ変数、インスペクターで設定する場合はnewはいらない
    public List<CharacterData> allCharas = new List<CharacterData>();// 問題一覧(アタッチで格納)
    // CharacterData chara_instance = Instantiate(CharacterPrefab) as CharacterData;
    //     //生成したインスタンスをリストで持っておく
    //     allCharas.Add(chara_instance);

    public static List<CharacterData> selectCharas;//一覧から問題を抜き出す箱
    public static int scores;//合計得点を表示(シーンを切り替えても消えないようにする)
    public int quizCount = 0;//今何問目かを記録

    //public int ans;//回答時の得点(引数)を受け取る箱


    public void SelectQuiz()//問題を入れるメソッド
    {
        // 抽選結果を入れるリストのインスタンスを作成
        selectCharas = new List<CharacterData>();
        for (int i = 0; i < 3; i++)
        {
            // ランダムな内容を１つ抽選、取得
            int index = Random.Range(0, selectCharas.Count);
            CharacterData quiz = allCharas[index];//quizに一つ問題を入れる
            selectCharas.Add(quiz);//selectCharasに問題を加える

            // 取得した内容を一覧のリストから削除
            allCharas.RemoveAt(index);
        }
    }

    // public object QuizCount()
    // {
    //     selectCharas[0].SetActive;
    // }

    

    // public void SelectAnserAddScore(int ans)
    // {
    //     this.scores += ans;
    // }
 
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SelectQuiz();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
