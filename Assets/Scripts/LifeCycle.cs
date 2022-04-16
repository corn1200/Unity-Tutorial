using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {

    }
    
    void Update()
    {
        //델타타임이란 이전 프레임 완료까지 걸린 시간
        //프레임 값과 반비례하기 때문에 속도나 거리 등의 연산에 사용 시
        //프레임이 다른 두 유저간의 형평성을 맞출 수 있다
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime, 
            0,
            Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(vec);
    }
}
