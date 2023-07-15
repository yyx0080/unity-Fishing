using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataMangger : MonoBehaviour
{
    // Start is called before the first frame update
    public int coin;//金币
    public int bail;//鱼饵
    public int fishBodLevel = 0;//鱼竿等级,取决于装备的鱼竿,0 1 2 3.//默认为0
    //哪一种等级的鱼竿，就启动setactive哪一个等级的圈
    void Awake()
    {
        //节约内存小妙招
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
