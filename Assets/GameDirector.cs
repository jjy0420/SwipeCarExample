using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        //Find 메서드를 통해 오브젝트 이름을 인수로 전달하여 게임 씬 안에서 오브젝트를 반환함
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        /*      //게임 오브젝트의 좌표는 오브젝트이름.transform.position 으로 구할 수 있다. 
                float length = this.flag.transform.position.x - this.car.transform.position.x;
                //ToString("F2")는 소수 둘째짜리까지 표현할떄 이용한다.
                //고정 소수점엔 F자릿수, 정수형엔 D자릿수로 표현한다.
                this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";*/
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임 오버!";
        }
    }
}
