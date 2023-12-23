using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    //このクラスの役割
    //問題のデータインスタンスを生成(unity上でアタッチ)
    //自身に対応する回答ボタンが押されたときにスコアを反映するメソッドを所持

    public int num;
    public bool choice = false;
    public int likeA = 33;
    public int likeB = 10;
    public int likeC = 5;
    public int likeD = 34;
    public Sprite  faice;
    public Sprite itemA;
    public Sprite itemB;
    public Sprite itemC;
    // Start is called before the first frame update

    public void OnLikeAClick()//Aを選択したときのスコアを加算
    {
        GameDirector.scores += this.likeA;
    }
    public void OnLikeBClick()//Bを選択したときのスコアを加算
    {
        GameDirector.scores += this.likeB;
    }
    public void OnLikeCClick()//Cを選択したときのスコアを加算
    {
        GameDirector.scores += this.likeC;
    }
     public void OnLikeDClick()//Dを選択したときのスコアを加算
    {
        GameDirector.scores += this.likeD;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
