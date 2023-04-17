using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class FishingCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fish;//鱼
    public FishType[] fishType = new FishType[3];
    public int fish_select;//
    public GameObject PointA;//右上角
    public GameObject PointB;//左下角
    private Vector3 targetPosition;//位置记录
    public GameObject panel;
    public struct FishType//鱼的种类
    {
        //稀有度
        public string name;//鱼的名字
        public float v;//速度
    };
    void Start()
    {
        fishType[0].name = "Fish_1";
        fishType[0].v = 100.0f;
        fishType[1].name = "Fish_2";
        fishType[1].v = 200.0f;
        fishType[2].name = "Fish_3";
        fishType[2].v = 300.0f;
        fish_select = Random.Range(0, 3);
        Debug.Log(fish_select);
        targetPosition = GetRandomPositionInBounds();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveFish();
    }
    //鱼随机移动，后期要考虑不同种类的鱼，有着不同种类的属性
    
    void MoveFish()
    {
        //接下来控制鱼在钓鱼板块内随机移动
        transform.position = Vector3.MoveTowards(transform.position, 
            targetPosition, fishType[fish_select].v*Time.deltaTime);
        //如果达到目标点，就换个目标点
        //为了避免卡住，要制定一个范围
        if (Mathf.Abs(transform.position.x - targetPosition.x) <= 5.0 &&
            Mathf.Abs(transform.position.y - targetPosition.y) <= 5.0)
        {
            targetPosition = GetRandomPositionInBounds();
        }
        //鱼的坐标要保持
        //Debug.Log("fish_pos = " + transform.position);
        //Debug.Log("pos = " + targetPosition);


    }
    //随机移动坐标函数
    private Vector3 GetRandomPositionInBounds()
    {
        float x = Random.Range(PointB.transform.position.x, PointA.transform.position.x);
        float y = Random.Range(PointB.transform.position.y, PointA.transform.position.y);
        return new Vector3(x, y, transform.position.z);
    }

}
