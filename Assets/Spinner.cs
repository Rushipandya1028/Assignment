using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xvalue = 0f;
    [ SerializeField] float yvalue = 0f;
    [ SerializeField] float zvalue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xvalue, yvalue, zvalue);
    }
}
