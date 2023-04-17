using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeFishCircle : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider2D fish_collider;
    public CircleCollider2D circle_collider;
    public Slider slider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //isInTheCircle();
        ChangeSillder();
    }
    //判断是否重叠
    bool isInTheCircle()
    {
        if(circle_collider.IsTouching(fish_collider))
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
        Debug.Log(slider.value);
        if(isInTheCircle())
        {
            slider.value += 0.0005f;
        }
        else
        {
            slider.value -= 0.0001f;
        }
        if(slider.value >= 0.96f)
        {      
            return 1;//1代表钓到鱼
        }
        else if(slider.value<=0.079)
        {
            return -1;//代表鱼逃跑
        }
        return 0;//还在钓鱼中
    }
    
    
}
