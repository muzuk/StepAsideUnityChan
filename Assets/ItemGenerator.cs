using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemGenerator : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity�����ƃJ�����̋���
    private float difference;
    //carPrefab������
    public GameObject carPrefab;
    //coinPrefab������
    public GameObject coinPrefab;
    //cornPrefab������
    public GameObject conePrefab;
    //�X�^�[�g�n�_
    private int startPos = 80;
    //�S�[���n�_
    private int goalPos = 360;
    //�A�C�e�����o��x�����͈̔�
    private float posRange = 3.4f;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        // Unitychan�I�u�W�F�N�g��Tag������
        if (other.gameObject.tag == "UnitychanTag")
        {
            // �ڐG�����I�u�W�F�N�g�̍��W���擾
            Vector3 hitPos = other.transform.position;

            //�ǂ̃A�C�e�����o���̂��������_���ɐݒ�
            int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //�R�[����x�������Ɉ꒼���ɐ���
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, other.transform.position.z + 50);
                    }
                }
                else
                {
                    //���[�����ƂɃA�C�e���𐶐�
                    for (int j = -1; j <= 1; j++)
                    {
                        //�A�C�e���̎�ނ����߂�
                        int item = Random.Range(1, 11);
                        //�A�C�e����u��Z���W�̃I�t�Z�b�g�������_���ɐݒ�
                        int offsetZ = Random.Range(-5, 6);
                        //60%�R�C���z�u:30%�Ԕz�u:10%�����Ȃ�
                        if (1 <= item && item <= 6)
                        {
                            //�R�C���𐶐�
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y,  other.transform.position.z + 50);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //�Ԃ𐶐�
                            GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, other.transform.position.z + 50);
                        }
                    }
                }
          
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    }

