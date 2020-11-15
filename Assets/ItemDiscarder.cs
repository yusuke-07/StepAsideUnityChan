using UnityEngine;
using System.Collections;

public class ItemDiscarder : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんと障害物の距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんと障害物の位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //障害物がUnityちゃんを通り過ぎて画面外の位置に達した場合
        if (this.difference > 8)
        {
            //障害物を破棄する
            Destroy(this.gameObject);
        }
    }
}
