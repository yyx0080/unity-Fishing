using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update

    Gyroscope go;
    public GameObject PointA;//右上角
    public GameObject PointB;//左下角
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
    //这个函数用来输出一些陀螺仪的信息
    void TestShowOut()
    {
        Debug.Log("旋转速率=" + go.rotationRate);
        Debug.Log("姿态(方向)=" + go.attitude);
        Debug.Log("重力加速度（力）=" + go.gravity);
        Debug.Log("用户给予设备的加速度=" + go.userAcceleration);
    }
    void MoveFishCircle()
    {
        //限制一下圆圈移动的范围
        //if (transform.position.x > PointA.transform.position.x)
        //if (transform.position.x < PointB.transform.position.x)
        //if (transform.position.y > PointA.transform.position.y)
        //if (transform.position.y < PointB.transform.position.y)
        transform.Translate(go.gravity.x * 520.0f * Time.deltaTime, go.gravity.y * 520.0f * Time.deltaTime, transform.position.z);
        //transform.Translate(100.0f * Time.deltaTime, 2* 100.0f * Time.deltaTime, transform.position.z);
        
        //Debug.Log(transform.position);
    }
}
