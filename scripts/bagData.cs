using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagData : MonoBehaviour
{
    // Start is called before the first frame update
    public bool []isHaveWhichBod;
    public GameObject NoBod;
    public GameObject EquSuc;
    public Text Level;
    public Text NumAboutBail;
    public Text coinText;
    public Text bailText;
    void Awake()
    {
        //��Լ�ڴ�С����
        if (GameObject.FindGameObjectsWithTag("bag").Length > 1)
        {
            Destroy(this.gameObject);
            
        }        
        else
        {
            DontDestroyOnLoad(this.gameObject);
            
        }         
            
        

        //DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetText();
    }
    public void EquipBod1()
    {
        //���ж���û��������
        if (isHaveWhichBod[1] == false)
        {
            //����û��������
            NoBod.SetActive(true);
        }
        else
        {
            //�����ɹ�װ�������,�л���͵ȼ�
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel = 1;
            EquSuc.SetActive(true);
        }
    }
    public void EquipBod2()
    {
        //���ж���û��������
        if (isHaveWhichBod[2] == false)
        {
            //����û��������
            NoBod.SetActive(true);
        }
        else
        {
            //�����ɹ�װ�������,�л���͵ȼ�
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel = 2;
            EquSuc.SetActive(true);
        }
    }
    public void EquipBod3()
    {
        //���ж���û��������
        if (isHaveWhichBod[3] == false)
        {
            //����û��������
            NoBod.SetActive(true);
        }
        else
        {
            //�����ɹ�װ�������,�л���͵ȼ�
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel = 3;
            EquSuc.SetActive(true);
        }
    }
    void SetText()
    {
        Level.text = "Ŀǰ��͵ȼ�"+
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel.ToString();
        NumAboutBail.text = GameObject.Find("DataMangger").GetComponent<dataMangger>().bail.ToString();
        coinText.text = GameObject.Find("DataMangger").GetComponent<dataMangger>().coin.ToString();
        bailText.text = GameObject.Find("DataMangger").GetComponent<dataMangger>().bail.ToString();

    }
}
