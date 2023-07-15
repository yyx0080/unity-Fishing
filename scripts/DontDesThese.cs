using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDesThese : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //节约内存小妙招
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
