using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    //Public Vars
    public float speed;
    public float gravity;

    //Private Vars
    private CharacterController _characterController;
    private float currentGravity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = gameObject.GetComponent <CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 finalMovement = Movement() + ApplyGravity();
        _characterController.Move(finalMovement * Time.deltaTime);
    }

    Vector3 ApplyGravity()
    {
        Vector3 gravityMovement = new Vector3(0, -currentGravity, 0);
        currentGravity += gravity * Time.deltaTime;

        if(_characterController.isGrounded == true)
        {
            if(currentGravity > 1)
               currentGravity = 1f;
        }

        return gravityMovement;
    }

    Vector3 Movement()
    {
        Vector3 moveVector = Vector3.zero;

        moveVector += transform.forward * Input.GetAxis("Vertical");
        moveVector += transform.right * Input.GetAxis("Horizontal");

        moveVector *= speed;

        return moveVector;
    }
}
