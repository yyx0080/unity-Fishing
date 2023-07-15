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
    public GameObject notional;//提示用户鱼饵不足的牌子
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFishSystem()
    {
        //这里先判断哪一种鱼竿
        ChangeBodFun();
        //这里要扣掉一个鱼饵，如果鱼饵不足，就会提示去商店购买
        int yuer = GameObject.Find("DataMangger").GetComponent<dataMangger>().bail;
        Debug.Log("鱼饵" + yuer);
        if (yuer > 0)
        {
            fishSystem.SetActive(true);
            goFailedPanel.SetActive(false);
            goSucPanel.SetActive(false);
            slider.value = 0.5f;
            GameObject.Find("DataMangger").GetComponent<dataMangger>().bail -= 1;//扣除一个鱼饵
            return;
        }
        else
        {
            //弹出购买商店界面，购买鱼饵
            //然后重新开始钓鱼
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
