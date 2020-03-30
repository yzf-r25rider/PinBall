using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ポイント変数の宣言
    int Point = 0;


    private GameObject PointText;


    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得

         this.gameoverText = GameObject.Find("GameOverText");

        this.PointText = GameObject.Find("PointText");


    }

    

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

       

        
        }
    void OnCollisionEnter(Collision other)
    {
        //小さい星に当たった場合
        if (other.gameObject.tag == "SmallStarTag")
        {
            Point = Point + 1;
        }
        //大きい星に当たった場合
        if (other.gameObject.tag == "LargeStarTag")
        {
            Point = Point + 2;
        }
        //小さい雲に当たった場合
        if (other.gameObject.tag == "SmallCloudTag")
        {
            Point = Point +2;
        }

        if (other.gameObject.tag == "LargeCloudTag")
        {
            Point = Point +3;
        }

     Debug.Log(Point);
     this.PointText.GetComponent<Text>().text = Point.ToString();


    }




}
