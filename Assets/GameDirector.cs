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
        //Find �޼��带 ���� ������Ʈ �̸��� �μ��� �����Ͽ� ���� �� �ȿ��� ������Ʈ�� ��ȯ��
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        /*      //���� ������Ʈ�� ��ǥ�� ������Ʈ�̸�.transform.position ���� ���� �� �ִ�. 
                float length = this.flag.transform.position.x - this.car.transform.position.x;
                //ToString("F2")�� �Ҽ� ��°¥������ ǥ���ҋ� �̿��Ѵ�.
                //���� �Ҽ����� F�ڸ���, �������� D�ڸ����� ǥ���Ѵ�.
                this.distance.GetComponent<Text>().text = "��ǥ �������� " + length.ToString("F2") + "m";*/
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ �������� " + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "���� ����!";
        }
    }
}
