using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    const int a = 4;

    int b = 100;

    // 게임 오브젝트가 처음 생성 되었을 때 호출되는 함수
    // 초기값을 세팅 할때 사용 Hp, Level, name 등
    // 한번 실행되고 더이상 실행되지 않는 함수
    void Start()
    {
        //a = 100;
        Debug.Log(a + b);
    }

    // 매 프레임마다 동작하는 함수
    // 매 프레임 연산을 함
    // 특정연산 
    void Update()
    {
        
    }
}
