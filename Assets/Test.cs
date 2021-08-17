using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列の宣言と初期化
        int[] array = {2,3,5,7,11};
        //順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //逆順に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //Bossクラスをインスタンス化
        Boss lastBoss = new Boss();
        //mpがあるかぎり攻撃する
        while (true)
        {
            lastBoss.Magic();
            if (!lastBoss.isMagicAvalable) break;
        }
        


    }

    // Update is called once per frame
    void Update()
    {
    }


}

public class Boss
{
    private int mp = 53;
    public bool isMagicAvalable;

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.isMagicAvalable = true;
            this.mp -= 5;
            Debug.Log($"魔法攻撃をした。残りMPは{this.mp}。");
        }
        else
        {
            this.isMagicAvalable = false;
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }

}
