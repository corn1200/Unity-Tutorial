using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // 고정된 프레임으로 계속 호출하기 때문에 CPU를 많이 쓴다
    // 대부분 물리 로직만 포함한다
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    // 실행하는 환경에 따라서 실행 주기가 떨어질 수 있다
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
