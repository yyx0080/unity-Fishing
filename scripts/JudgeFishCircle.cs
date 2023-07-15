using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeFishCircle : MonoBehaviour
{
    public GameObject goSucPanel;
    public GameObject goFailedPanel;
    public BoxCollider2D fish_collider;
    public CircleCollider2D circle_collider;
    public CircleCollider2D circle_collider1;
    public CircleCollider2D circle_collider2;
    public CircleCollider2D circle_collider3;
    public Slider slider;
    protected EnumState current;
    bool isJiaGuole = false;
    
    void Start()
    {
        PuSetRaycastTarget(goSucPanel);
        PuSetRaycastTarget(goFailedPanel);
        goSucPanel.SetActive(false);
        goFailedPanel.SetActive(false);
        slider.value = 0.5f;
    }

    void Update()
    {
        //isInTheCircle();
        
        ChangeSillder();
    }

    //判断是否重叠
    bool isInTheCircle()
    {
        if(   circle_collider.IsTouching(fish_collider)
            ||circle_collider1.IsTouching(fish_collider)
            ||circle_collider2.IsTouching(fish_collider)
            ||circle_collider3.IsTouching(fish_collider))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //写一个根据重叠来控制进度条的函数
    int ChangeSillder()
    {
        //如果在圆内，增加进度条
        //Debug.Log(slider.value);
        if(isInTheCircle())
        {
            slider.value += 0.0005f;
        }
        else
        {
            //slider.value += 0.0001f;
            slider.value -= 0.0001f;
        }

        if(slider.value >= 0.96f)
        {
            //Debug.Log("成功了!");
            if (current != EnumState.Suc)
            {
                goSucPanel.SetActive(true);
                current = EnumState.Suc;
            }
            //加钱
            int value = GameObject.Find("fish").GetComponent<FishingCtrl>().fish_select;
            int money = 0;
            if(value == 0)
            {
                money = 20;
            }
            if(value == 1)
            {
                money = 50;
            }
            if(value == 2)
            {
                money = 150;
            }
            if(isJiaGuole == false)
            {
                GameObject.Find("DataMangger").GetComponent<dataMangger>().coin += money;
                isJiaGuole = true;
            }
            
            return 1;//1代表钓到鱼
        }
        else if(slider.value<=0.079)
        {
            //Debug.Log("失败了!");
            if (current != EnumState.Fail)
            {
                goFailedPanel.SetActive(true);
                current = EnumState.Fail;
            }
   
            return -1;//代表鱼逃跑
        }
        else
        {
            current = EnumState.Normal;
        }

        return 0;//还在钓鱼中
    }

    /// <summary>
    /// 设置UI触发           
    /// </summary>
    public void PuSetRaycastTarget(GameObject obj)
    {
        obj.AddComponent<UIClick>();
        if (!obj.TryGetComponent<Image>(out var img)) return;

        img.raycastTarget = true;
    }

    public enum EnumState
    {
        Normal,
        Suc,
        Fail
    }
    
    

}
