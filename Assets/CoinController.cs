using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //カメラのオブジェクト
    private GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        //カメラのオブジェクトを取得
        this.maincamera = GameObject.Find("Main Camera");
        //回転を開始する速度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);
        //コインを削除する
        if (this.transform.position.z < maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
