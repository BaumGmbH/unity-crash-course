using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Eine Kolliesieon hat statgefunden!");
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
