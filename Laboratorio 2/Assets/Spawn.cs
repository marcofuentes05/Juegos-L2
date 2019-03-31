using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public GameObject prefab;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }
    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            if (!player)
                player = Instantiate(prefab, pos, Quaternion.identity);
            
        }
    }
}
