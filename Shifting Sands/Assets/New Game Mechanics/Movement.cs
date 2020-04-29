using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 position;

    public int speed = 10;
    private float gravity = 50.0f;
    public int jumpSpeed = 50000;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.y = 0;
        position.z = speed * Input.GetAxis("Vertical");
        if (position.x != 0 || position.z != 0 )
        {
            transform.rotation = Quaternion.LookRotation(position);
        }
        position.y -= gravity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            position.y = jumpSpeed;
        }

        controller.Move(position * Time.deltaTime);
    }

    public void SlowSpeed()
    {
        speed = 50;
        jumpSpeed = 10;
    }

    public void ReturnSpeed()
    {
        speed = 100;
        jumpSpeed = 50;
    }

}
