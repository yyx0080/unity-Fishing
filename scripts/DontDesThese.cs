using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDesThese : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //��Լ�ڴ�С����
        if (GameObject.FindGameObjectsWithTag("DontDesThese").Length > 1)
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
