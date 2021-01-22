using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //void Awake()
    //{
    //    Debug.Log("플레이어 데이터가 준비되었습니다.");
    //}

    //void OnEnable()
    //{
    //    Debug.Log("플레이어가 로그인했습니다.");

    //}

    //void Start()
    //{
    //    Debug.Log("사냥 장비를 챙겼습니다.");
    //}

    //void FixedUpdate()
    //{
    //    Debug.Log("이동~");
    //}
    void Start()
    {
        

        //int number = 4; // 스칼라 값

    }

    void Update()
    {

        Vector3 vec = new Vector3
            (Input.GetAxis("Horizontal"),
             Input.GetAxis("Vertical"),
             0);


             transform.Translate(vec);





        //if (Input.anyKeyDown)
        //Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //if (Input.GetButton("Horizontal"))
        //    Debug.Log("횡 이동 중 ...!" + Input.GetAxisRaw("Horizontal"));

        //if (Input.GetButton("Vertical"))
        //    Debug.Log("종 이동 중 ...!" + Input.GetAxisRaw("Vertical"));
        //if (Input.GetButton("Fire1"))
        //    Debug.Log("점프 모으는중...");

        //if (Input.GetButtonUp("Fire1"))
        //    Debug.Log("슈퍼 점프!");


        //if (Input.GetMouseButtonDown(0))
        //Debug.Log("미사일 발사!");

        //if (Input.GetMouseButton(0))
        //Debug.Log("미사일 모으는 중...");

        //if (Input.GetMouseButtonUp(0))
        //Debug.Log("슈퍼 미사일 발사!!");


        //if (Input.GetKeyDown(KeyCode.Return))
        //Debug.Log("아이템을 구입하였습니다.");

        //if (Input.GetKey(KeyCode.LeftArrow))
        //Debug.Log("왼쪽으로 이동 중.");

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //Debug.Log("오른쪽 이동을 멈추었습니다.");


    }






    //if (Input.anyKey)
    //{
    //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
    //}


    //Debug.Log("몬스터 사냥!");


    //void LateUpdate()
    //{
    //    Debug.Log("경험치 획득.");

    //}

    //void OnDisable()
    //{
    //    Debug.Log("플레이어가 로그아웃했습니다.");

    //}

    //void OnDestroy()
    //{
    //    Debug.Log("플레이어 데이터가 해제하였습니다.");
    //}








}
