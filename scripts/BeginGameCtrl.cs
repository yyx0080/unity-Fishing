using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginGameCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fishSystem;
    public GameObject goSucPanel;
    public GameObject goFailedPanel;
    public Slider slider;
    public GameObject c0;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject notional;//��ʾ�û�������������
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFishSystem()
    {
        //�������ж���һ�����
        ChangeBodFun();
        //����Ҫ�۵�һ����������������㣬�ͻ���ʾȥ�̵깺��
        int yuer = GameObject.Find("DataMangger").GetComponent<dataMangger>().bail;
        Debug.Log("���" + yuer);
        if (yuer > 0)
        {
            fishSystem.SetActive(true);
            goFailedPanel.SetActive(false);
            goSucPanel.SetActive(false);
            slider.value = 0.5f;
            GameObject.Find("DataMangger").GetComponent<dataMangger>().bail -= 1;//�۳�һ�����
            return;
        }
        else
        {
            //���������̵���棬�������
            //Ȼ�����¿�ʼ����
            notional.SetActive(true);            

        }
        
    }
    void ChangeBodFun()
    {
        int level = GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel;
        if(level == 0)
        {
            c0.SetActive(true);
            c1.SetActive(false);
            c2.SetActive(false);
            c3.SetActive(false);
        }
        if (level == 1)
        {
            c0.SetActive(false);
            c1.SetActive(true);
            c2.SetActive(false);
            c3.SetActive(false);
        }
        if (level == 2)
        {
            c0.SetActive(false);
            c1.SetActive(false);
            c2.SetActive(true);
            c3.SetActive(false);
        }
        if (level == 3)
        {
            c0.SetActive(false);
            c1.SetActive(false);
            c2.SetActive(false);
            c3.SetActive(true);
        }
    }
}
