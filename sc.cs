using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public GameObject st;
    void Start()
    {
        //回数カウント
        GameObject.Find("Main Camera").GetComponent<count>().countda++;
        int count = GameObject.Find("Main Camera").GetComponent<count>().countda;
        if (count < 10000)
        {
            //一辺の長さを変えたいときはこれとInspectorのpositon(xとz)、scale.xをチェンジ(n倍ずつする)
            int edge = 30;
            //線の太さを変えたいときはこことInspectorのscale.zをチェンジ（これとscale.zがかけて10になるようにする）
            int width = 10000;            

            //初期スケール
            Vector3 scl = this.gameObject.transform.localScale;

            //高さ
            float root = 5 / (2 * Mathf.Sqrt(3));
            //横
            float x = 5 / 6f;
            float x2 = 10 / 3f;

            //大きさ調整
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


            //一本目
            GameObject stick = Instantiate(st);
            //親を作って、スケールと座標を指定
            stick.transform.SetParent(this.gameObject.transform);
            stick.transform.localScale = new Vector3(scl.x/edge, 1, 1);
            stick.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec = new Vector3(-x, 0, root * (width / quotient));
            stick.transform.localPosition = vec;
            //親を解除して回転させる
            stick.transform.SetParent(null);
            Vector3 angle = transform.eulerAngles;
            stick.transform.rotation = Quaternion.Euler(0, angle.y - 60, 0);

            //二本目
            GameObject stick2 = Instantiate(st);
            //親を作って、スケールと座標を指定
            stick2.transform.SetParent(this.gameObject.transform);
            stick2.transform.localScale = new Vector3(scl.x / edge, 1, 1);
            stick2.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec2 = new Vector3(x, 0, root * (width /quotient));
            stick2.transform.localPosition = vec2;
            //親を解除して回転させる
            stick2.transform.SetParent(null);
            Vector3 angle2 = transform.eulerAngles;
            stick2.transform.rotation = Quaternion.Euler(0, angle2.y + 60, 0);

            //三本目
            GameObject stick3 = Instantiate(st);
            //親を作って、スケールと座標を指定
            stick3.transform.SetParent(this.gameObject.transform);
            stick3.transform.localScale = new Vector3(scl.x / edge, 1, 1);
            stick3.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec3 = new Vector3(x2, 0, 0);
            stick3.transform.localPosition = vec3;
            //親を解除して回転させる
            stick3.transform.SetParent(null);
            Vector3 angle3 = transform.eulerAngles;
            stick3.transform.rotation = Quaternion.Euler(0, angle3.y, 0);

            //四本目
            GameObject stick4 = Instantiate(st);
            //親を作って、スケールと座標を指定
            stick4.transform.SetParent(this.gameObject.transform);
            stick4.transform.localScale = new Vector3(scl.x / edge, 1, 1);
            stick4.transform.rotation = this.gameObject.transform.rotation;
            Vector3 vec4 = new Vector3(-x2, 0, 0);
            stick4.transform.localPosition = vec4;
            //親を解除して回転させる
            stick4.transform.SetParent(null);
            Vector3 angle4 = transform.eulerAngles;
            stick4.transform.rotation = Quaternion.Euler(0, angle4.y, 0);
        }
    }

}
