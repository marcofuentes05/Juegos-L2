using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishS : MonoBehaviour
{
    private GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Pelota");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (pelota.powerUps != 4)
        {
            Destroy(other.gameObject);
        }
    }
}
