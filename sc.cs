using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public GameObject st;
    void Start()
    {
        //�񐔃J�E���g
        GameObject.Find("Main Camera").GetComponent<count>().countda++;
        int count = GameObject.Find("Main Camera").GetComponent<count>().countda;
        if (count < 10000)
        {
            //��ӂ̒�����ς������Ƃ��͂����Inspector��positon(x��z)�Ascale.x���`�F���W(n�{������)
            int edge = 30;
            //���̑�����ς������Ƃ��͂�����Inspector��scale.z���`�F���W�i�����scale.z��������10�ɂȂ�悤�ɂ���j
            int width = 10000;            

            //�����X�P�[��
            Vector3 scl = this.gameObject.transform.localScale;

            //����
            float root = 5 / (2 * Mathf.Sqrt(3));
            //��
            float x = 5 / 6f;
            float x2 = 10 / 3f;

            //�傫������
            int size = 0;
            if (count != 3 && count != 1 && count != 2)
            {
                size= (int)Mathf.Floor(Mathf.Log(count, 4));
                Debug.Log(size);
            }
            if (size != 0)
            {
                scl.x = scl.x*Mathf.Pow(3, size);
            }
            int quotient =(int) Mathf.Pow(3, size);


            //��{��
            GameObject stick = Instantiate(st);
            //�e������āA�X�P�[���ƍ��W���w��
            stick.transform.SetParent(this.gameObject.transform);
            stick.transform.localScale = new Vector3(scl.x/edge, 1, 1);
            stick.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec = new Vector3(-x, 0, root * (width / quotient));
            stick.transform.localPosition = vec;
            //�e���������ĉ�]������
            stick.transform.SetParent(null);
            Vector3 angle = transform.eulerAngles;
            stick.transform.rotation = Quaternion.Euler(0, angle.y - 60, 0);

            //��{��
            GameObject stick2 = Instantiate(st);
            //�e������āA�X�P�[���ƍ��W���w��
            stick2.transform.SetParent(this.gameObject.transform);
            stick2.transform.localScale = new Vector3(scl.x / edge, 1, 1);
            stick2.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec2 = new Vector3(x, 0, root * (width /quotient));
            stick2.transform.localPosition = vec2;
            //�e���������ĉ�]������
            stick2.transform.SetParent(null);
            Vector3 angle2 = transform.eulerAngles;
            stick2.transform.rotation = Quaternion.Euler(0, angle2.y + 60, 0);

            //�O�{��
            GameObject stick3 = Instantiate(st);
            //�e������āA�X�P�[���ƍ��W���w��
            stick3.transform.SetParent(this.gameObject.transform);
            stick3.transform.localScale = new Vector3(scl.x / edge, 1, 1);
            stick3.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec3 = new Vector3(x2, 0, 0);
            stick3.transform.localPosition = vec3;
            //�e���������ĉ�]������
            stick3.transform.SetParent(null);
            Vector3 angle3 = transform.eulerAngles;
            stick3.transform.rotation = Quaternion.Euler(0, angle3.y, 0);

            //�l�{��
            GameObject stick4 = Instantiate(st);
            //�e������āA�X�P�[���ƍ��W���w��
            stick4.transform.SetParent(this.gameObject.transform);
            stick4.transform.localScale = new Vector3(scl.x / edge, 1, 1);
            stick4.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec4 = new Vector3(-x2, 0, 0);
            stick4.transform.localPosition = vec4;
            //�e���������ĉ�]������
            stick4.transform.SetParent(null);
            Vector3 angle4 = transform.eulerAngles;
            stick4.transform.rotation = Quaternion.Euler(0, angle4.y, 0);
        }
    }

}
