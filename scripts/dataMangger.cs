using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataMangger : MonoBehaviour
{
    // Start is called before the first frame update
    public int coin;//���
    public int bail;//���
    public int fishBodLevel = 0;//��͵ȼ�,ȡ����װ�������,0 1 2 3.//Ĭ��Ϊ0
    //��һ�ֵȼ�����ͣ�������setactive��һ���ȼ���Ȧ
    void Awake()
    {
        //��Լ�ڴ�С����
        if (GameObject.FindGameObjectsWithTag("Global").Length > 1)
            Destroy(this.gameObject);
        else
            DontDestroyOnLoad(this.gameObject);
        //DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
