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
    private float posRange = 3.4f;

    // Start is called before the first frame update
    void Start()
    {
        //���̋������Ƃ�Line�𐶐�
        for (int i = startPos; i < goalPos; i += 25)
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