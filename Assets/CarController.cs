using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition; //마우스 클릭했을 때 좌표
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition; // 마우스 버튼을 손가락에서 떼었을 때 좌표
            float swipeLength = endPos.x - this.startPos.x; //두 좌표값의 차이 = 스와이프길이 

            this.speed = swipeLength / 4000.0f; //스와이프 길이만큼 처음 속도로 적용 / 숫자가 커질수록 속도가 느려진다
        }

        transform.Translate(this.speed, 0, 0); //이동
        this.speed *= 0.98f; //감속


    }
}
