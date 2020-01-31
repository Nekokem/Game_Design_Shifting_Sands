using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    public int speed = 10;
    public float gravity = 10.0f;
    public int jumpSpeed = 20;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.z = speed * Input.GetAxis("Vertical");
        position.z -= gravity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            position.y = jumpSpeed;
        }

        controller.Move(position * Time.deltaTime);
    }
    
}
