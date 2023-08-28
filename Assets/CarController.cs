using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //カメラのオブジェクト
    private GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        //カメラのオブジェクトを取得
        this.maincamera = GameObject.Find("Main Camera");
    
    }

    // Update is called once per frame
    void Update()
    {
 
        //コインを削除する
        if (this.transform.position.z < maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
