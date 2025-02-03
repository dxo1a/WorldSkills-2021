using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private Collider _col;

    //Скорость по осям и по вертикали 
    public float v_speed;
    public float h_speed;
    public float upSpeed;

    private bool moveLeft, moveRight, moveForward, moveBack, moveUp;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
    }

    void FixedUpdate()
    {
        //Движение влево, вправо, вперёд, назад и вверх
        if (moveLeft)
        {
            _rb.AddForce(Vector3.left * h_speed);
        }
        if (moveRight)
        {
            _rb.AddForce(Vector3.right * h_speed);
        }
        if (moveForward)
        {
            _rb.AddForce(Vector3.forward * v_speed);
        }
        if (moveBack)
        {
            _rb.AddForce(Vector3.back * v_speed);
        }
        if (moveUp)
        {
            _rb.AddForce(Vector3.up * upSpeed);
        }
    }

    //Доступность движений
    public void MoveLeft()
    {
        moveLeft = true;
    }

    public void MoveRight()
    {
        moveRight = true;
    }

    public void MoveForward()
    {
        moveForward = true;
    }

    public void MoveBack()
    {
        moveBack = true;
    }

    public void MoveLeftStop()
    {
        moveLeft = false;
    }

    public void MoveRightStop()
    {
        moveRight = false;
    }

    public void MoveForwardStop()
    {
        moveForward = false;
    }

    public void MoveBackStop()
    {
        moveBack = false;
    }

    public void MoveUp()
    {
        moveUp = true;
    }

    public void MoveUpStop()
    {
        moveUp = false;
    }
}
