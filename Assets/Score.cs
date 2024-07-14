using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    int hits = 0;
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            hits++;
            UnityEngine.Debug.Log("Bumped with the wall this times :" + hits);
        
        }
    
        
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
