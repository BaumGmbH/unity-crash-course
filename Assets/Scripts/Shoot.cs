using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletObject;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet =Instantiate(bulletObject, transform.position, transform.rotation);
            Destroy(bullet, 1.5f);
        }
    }
}
