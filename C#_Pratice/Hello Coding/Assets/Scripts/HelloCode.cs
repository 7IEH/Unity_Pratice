using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    enum SEX_TYPE
    {
        MALE,
        FEMALE
    };


    // Start is called before the first frame update
    void Start()
    {
        // 1. Hello World!
        Debug.Log("Hello Wowrld");

        // 2. Function Practice
        Introdeuce("���", 'A', 17, 168.3f, SEX_TYPE.FEMALE);
    }

    void Introdeuce(string _name, char _bloodType, int _age, float _height, SEX_TYPE _type)
    {
        Debug.Log("�̸� :" + _name);
        Debug.Log("������ :" + _bloodType);
        Debug.Log("���� :" + _age);
        Debug.Log("Ű :" + _height);
        if (_type == SEX_TYPE.MALE)
        {
            Debug.Log("���� : ����");
        }
        else
        {
            Debug.Log("���� : ����");
        }
    }
}
