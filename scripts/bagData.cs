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
        //节约内存小妙招
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
        //先判断有没有这个鱼竿
        if (isHaveWhichBod[1] == false)
        {
            //弹出没有这个鱼竿
            NoBod.SetActive(true);
        }
        else
        {
            //弹出成功装备此鱼竿,切换鱼竿等级
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel = 1;
            EquSuc.SetActive(true);
        }
    }
    public void EquipBod2()
    {
        //先判断有没有这个鱼竿
        if (isHaveWhichBod[2] == false)
        {
            //弹出没有这个鱼竿
            NoBod.SetActive(true);
        }
        else
        {
            //弹出成功装备此鱼竿,切换鱼竿等级
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel = 2;
            EquSuc.SetActive(true);
        }
    }
    public void EquipBod3()
    {
        //先判断有没有这个鱼竿
        if (isHaveWhichBod[3] == false)
        {
            //弹出没有这个鱼竿
            NoBod.SetActive(true);
        }
        else
        {
            //弹出成功装备此鱼竿,切换鱼竿等级
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel = 3;
            EquSuc.SetActive(true);
        }
    }
    void SetText()
    {
        Level.text = "目前鱼竿等级"+
            GameObject.Find("DataMangger").GetComponent<dataMangger>().fishBodLevel.ToString();
        NumAboutBail.text = GameObject.Find("DataMangger").GetComponent<dataMangger>().bail.ToString();
        coinText.text = GameObject.Find("DataMangger").GetComponent<dataMangger>().coin.ToString();
        bailText.text = GameObject.Find("DataMangger").GetComponent<dataMangger>().bail.ToString();

    }
}
