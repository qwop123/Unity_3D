using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public Transform target;        // 따라다닐 타겟 오브젝트의 Transform

    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position = new Vector3(target.position.x, target.position.y + 1.9f, target.position.z - 2.3f);
       
        //tr.LookAt(target);
    }
}
