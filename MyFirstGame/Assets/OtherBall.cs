using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;


    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Myball")
            mat.color = new Color(0, 0, 0);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Myball")
            mat.color = new Color(1, 1, 1);
    }

}

// 실제 물리적인 충돌로 발생하는 이벤트
//void OnCollisionEnter(Collision collision) { }
//void OnCollisionStay(Collision collision) { }
//void OnCollisionExit(Collision collision) { }

// 콜라이더 충돌로 발생하는 이벤트
//void OnTriggerEnter(Collider other) { }
//void OnTriggerStay(Collider other) { }
//void OnTriggerExit(Collider other) { }