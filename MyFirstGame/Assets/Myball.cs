﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{

    Rigidbody rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector3(2, 4, 3);
       // rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigid.velocity = new Vector3.foward; //#1. 속력바꾸기

        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(

        Input.GetAxisRaw("Horizontal"), 0,
        Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);


        // 3. 회전력

       //  rigid.AddTorque(Vector3.up);

    }

   private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube" )
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {

        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
