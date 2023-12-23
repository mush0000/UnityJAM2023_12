using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CharacterData : MonoBehaviour
{

    public int num;
    public bool choice = false;
    public int likeA = 33;
    public int likeB = 10;
    public int likeC = 5;
    public int likeD = 34;
    public Image faice;
    public Image itemA;
    public Image itemB;
    public Image itemC;
    // Start is called before the first frame update

    public void OnItemAClick(int num)//Aを選択したときのスコアを加算
    {
        GameDirector.scores += num;
    }
    public void OnItemBClick(int num)//Bを選択したときのスコアを加算
    {
        GameDirector.scores += num;
    }
    public void OnItemCClick(int num)//Cを選択したときのスコアを加算
    {
        GameDirector.scores += num;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
