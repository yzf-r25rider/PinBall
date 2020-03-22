using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{
    //ポイントを表示する
    private GameObject Point;

    // Use this for initialization
    void Start()
    {
        //シーン中のPointオブジェクトを取得
        this.Point= GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {



    }
}