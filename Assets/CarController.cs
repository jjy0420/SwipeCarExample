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
            this.startPos = Input.mousePosition; //���콺 Ŭ������ �� ��ǥ
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition; // ���콺 ��ư�� �հ������� ������ �� ��ǥ
            float swipeLength = endPos.x - this.startPos.x; //�� ��ǥ���� ���� = ������������ 

            this.speed = swipeLength / 4000.0f; //�������� ���̸�ŭ ó�� �ӵ��� ���� / ���ڰ� Ŀ������ �ӵ��� ��������
        }

        transform.Translate(this.speed, 0, 0); //�̵�
        this.speed *= 0.98f; //����


    }
}
