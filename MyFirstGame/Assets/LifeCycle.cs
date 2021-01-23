using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    string title = "전설의";
    string playerName = "나검사";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        Debug.Log("Hello Unity!");


        // 1.변수
        //int level = 5;
        //float strength = 15.5f;
        //string playerName = "나검사";
        //bool isFullLevel = false; // or true

        //Debug.Log("용사의 이름은?");
        //Debug.Log(playerName);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만렙인가?");
        //Debug.Log(isFullLevel);

        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;




        //  Debug.Log("맵에 존재하는 몬스터의 레벨");
        //Debug.Log(monsterLevel[0]);
        //  Debug.Log(monsterLevel[1]);
        // Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        ////  items.RemoveAt(0);

        //  Debug.Log("가지고 있는 아이템");
        //  Debug.Log(items[0]);
        //  Debug.Log(items[1]);

        // 3. 연산자
        //int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        //Debug.Log("용사의 총 경험치는?");
        //Debug.Log(exp);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        //Debug.Log("다음 레벨까지 남은 경험치는?");
        //Debug.Log(nextExp);

        //string title = "전설의";
        //Debug.Log("용사의 이름은?");
        //Debug.Log(title + " " + playerName);

        string fullName = title + " " + playerName;
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        //Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        //Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        //int health = 30;
        //int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;

        //Debug.Log("튜토리얼이 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        //Debug.Log("용사의 상태가 나쁩니까?" + condition);

        // 4. 키워드

        //int float = 1;
        //string name = List;

        // 5. 조건문
        //if (condition == "나쁨")
        //{
        //    items.RemoveAt(0);
        //    health += 30;
        //    //Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요");
        //}
        //else
        //{
        //    //Debug.Log("플레이어 상태가 좋습니다");

        //}

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            //Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;

            //Debug.Log("마나포션30을 사용하였습니다.");

        }


        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;

            default:
                Debug.Log("??? 몬스터가 출현!");
                break;


        }

        // 6. 반복문

        while (health > 0)
        {
            health--;

            //Debug.Log("독 데미지를 입었습니다." + health);
            //else
            //Debug.Log("사망하였습니다");

            if (health == 10)
            {
                break;
                //Debug.Log("해독제를 사용합니다");
                //break;

            }

        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            //Debug.Log("붕대로 치료 중..." + health);
        }

        // foreach (int index = 0; index < monsters.Length; index++)
        //  Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);

        foreach (string monster in monsters)
        {
            // Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        Heal();

        for (int index = 0; index < monsters.Length; index++)
        {
            //Debug.Log("용사는 " + monsters[index] + "에게 " +
            //    Battle(monsterLevel[index]));
        }


        // 8. 클래스

        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + " 입니다");




    }


    



    // 7. 함수 (메소드)
    //int Heal(int currentHealth)
    //{
    //    currentHealth += 10;
    //    Debug.Log("힐을 받았습니다." + currentHealth);
    //    return currentHealth;
    //}
    
void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);

    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다";
        else
            result = "졌습니다";

        return result;
    }

}






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
////    Debug.Log("이동~");
////}
//void Start()
//{


//    //int number = 4; // 스칼라 값

//}

//void Update()
//{

//    Vector3 vec = new Vector3
//        (Input.GetAxis("Horizontal"),
//         Input.GetAxis("Vertical"),
//         0);


//         transform.Translate(vec);





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









