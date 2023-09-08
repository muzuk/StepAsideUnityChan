using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{

    //linePrefabを入れる
    public GameObject linePrefab;
    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;
    //Lineを出すx方向の範囲
    private float posRange = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //一定の距離ごとにLineを生成
        for (int i = startPos -50; i < goalPos -50 ; i += 15)
        {

            GameObject line = Instantiate(linePrefab);
            line.transform.position = new Vector3(posRange, line.transform.position.y, i);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}