using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{

    //linePrefab������
    public GameObject linePrefab;
    //�X�^�[�g�n�_
    private int startPos = 80;
    //�S�[���n�_
    private int goalPos = 360;
    //Line���o��x�����͈̔�
    private float posRange = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //���̋������Ƃ�Line�𐶐�
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