using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuatoirniumTest : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookVector = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(lookVector);   
    }
}
