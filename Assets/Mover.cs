using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    /*[SerializeField] float xvalue = 0.1f;*/
    //float yvalue = 0f;
    [SerializeField]float movespeed = 10f;
    void Start()
    {
        PrintInstructions();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use the arrow keys wsad to move");
        Debug.Log("Use the space bar to jump");

    }
    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue, 0, zvalue);
    }
}
