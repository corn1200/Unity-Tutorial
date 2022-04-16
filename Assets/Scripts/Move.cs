using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        //1.MoveTowards 일정하게 이동
        //transform.position = Vector3.MoveTowards(transform.position, target, 0.001f);

        //2.SmoothDamp 부드럽게 이동
        //Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.5f);

        //3.Lerp 선형보간 이동
        //transform.position = Vector3.Lerp(transform.position, target, 0.005f);

        //4.SLerp 구면 선형 이동
        transform.position = Vector3.Slerp(transform.position, target, 0.005f);
    }
}
