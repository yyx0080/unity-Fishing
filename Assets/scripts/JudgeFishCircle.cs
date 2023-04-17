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
    //�ж��Ƿ��ص�
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
    //дһ�������ص������ƽ������ĺ���
    int ChangeSillder()
    {
        //�����Բ�ڣ����ӽ�����
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
            return 1;//1���������
        }
        else if(slider.value<=0.079)
        {
            return -1;//����������
        }
        return 0;//���ڵ�����
    }
    
    
}
