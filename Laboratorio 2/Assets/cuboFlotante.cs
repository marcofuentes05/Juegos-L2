using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboFlotante : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 50, 0);
        transform.Rotate( Time.deltaTime * 50, 0,0);
        transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time)/3, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        pelota.powerUps += 1;   
    }
}
