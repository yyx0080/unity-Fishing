using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update

    Gyroscope go;
    public GameObject PointA;//���Ͻ�
    public GameObject PointB;//���½�
    void Start()
    {
        Input.gyro.enabled = true;
        go = Input.gyro;
    }

    // Update is called once per frame
    void Update()
    {
        //TestShowOut();
        MoveFishCircle();
    }
    //��������������һЩ�����ǵ���Ϣ
    void TestShowOut()
    {
        Debug.Log("��ת����=" + go.rotationRate);
        Debug.Log("��̬(����)=" + go.attitude);
        Debug.Log("�������ٶȣ�����=" + go.gravity);
        Debug.Log("�û������豸�ļ��ٶ�=" + go.userAcceleration);
    }
    void MoveFishCircle()
    {
        //����һ��ԲȦ�ƶ��ķ�Χ
        //if (transform.position.x > PointA.transform.position.x)
        //if (transform.position.x < PointB.transform.position.x)
        //if (transform.position.y > PointA.transform.position.y)
        //if (transform.position.y < PointB.transform.position.y)
        transform.Translate(go.gravity.x * 520.0f * Time.deltaTime, go.gravity.y * 520.0f * Time.deltaTime, transform.position.z);
        //transform.Translate(100.0f * Time.deltaTime, 2* 100.0f * Time.deltaTime, transform.position.z);
        
        //Debug.Log(transform.position);
    }
}
