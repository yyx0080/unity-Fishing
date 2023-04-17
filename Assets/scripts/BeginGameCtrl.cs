using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGameCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fishSystem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFishSystem()
    {
        fishSystem.SetActive(true);
    }
}
