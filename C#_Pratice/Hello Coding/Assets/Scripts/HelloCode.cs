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
        Introdeuce("라라", 'A', 17, 168.3f, SEX_TYPE.FEMALE);
    }

    void Introdeuce(string _name, char _bloodType, int _age, float _height, SEX_TYPE _type)
    {
        Debug.Log("이름 :" + _name);
        Debug.Log("혈액형 :" + _bloodType);
        Debug.Log("나이 :" + _age);
        Debug.Log("키 :" + _height);
        if (_type == SEX_TYPE.MALE)
        {
            Debug.Log("성별 : 남성");
        }
        else
        {
            Debug.Log("성별 : 여성");
        }
    }
}
