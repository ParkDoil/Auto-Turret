using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody _rigid;
    PlayerController _playerController;

    public float MoveSpeed = 1.5f;
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        _playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        float xSpeed = _playerController.X * MoveSpeed;
        float ZSpeed = _playerController.Z * MoveSpeed;

        _rigid.AddForce(xSpeed, 0f, ZSpeed);
    }
}
