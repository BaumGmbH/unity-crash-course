using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetect : MonoBehaviour
{
    private float speed = 10;

    // Update is called once per frame
    void Update()
    {
        float x_move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z_move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x_move, 0, z_move); 
    }
}
