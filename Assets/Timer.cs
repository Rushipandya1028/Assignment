using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{   
    MeshRenderer renderer;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    [SerializeField] float waittime = 5f; 
    

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > waittime)
        {
            
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
