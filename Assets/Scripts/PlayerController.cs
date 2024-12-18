using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerAnimation PlayerAnimation;
    
    [SerializeField] private float speed = 2f;

    [SerializeField] GameObject bullerPrefeb;
    [SerializeField] Transform bulletSpawn;
    [SerializeField] float bulletSpeed;

    public TimeManager timeManager;

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!timeManager.GameEnd)
        {
            handdleControl();
        }
    }

    private void handdleControl()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        characterController.Move(move * Time.deltaTime * speed);
        if (Input.GetMouseButtonDown(0))
        {

            GameObject bullet = Instantiate(bullerPrefeb, bulletSpawn.transform.position, bulletSpawn.transform.rotation);

            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

            bulletRigidbody.AddForce(0, 0, bulletSpeed, ForceMode.Impulse);
        }

        if (move != Vector3.zero)
        {

            if (move == Vector3.left)
            {
                PlayerAnimation.Left();
            }
            else if (move == Vector3.right)
            {
                PlayerAnimation.Right();
            }
        }
        else
        {
            PlayerAnimation.Idle();
        }
    }
}
