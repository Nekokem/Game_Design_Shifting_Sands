using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 position;

    public int speed = 10;
    private float gravity = 10.0f;
    public int jumpSpeed = 20;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.z = speed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            position.y = jumpSpeed;
        }

        controller.Move(position * Time.deltaTime);
    }

    public void SlowSpeed()
    {
        speed = 10;
        jumpSpeed = 10;
    }

    public void ReturnSpeed()
    {
        speed = 150;
        jumpSpeed = 50;
    }

}
