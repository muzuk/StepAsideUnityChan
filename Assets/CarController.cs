using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //�J�����̃I�u�W�F�N�g
    private GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        //�J�����̃I�u�W�F�N�g���擾
        this.maincamera = GameObject.Find("Main Camera");
    
    }

    // Update is called once per frame
    void Update()
    {
 
        //�R�C�����폜����
        if (this.transform.position.z < maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
