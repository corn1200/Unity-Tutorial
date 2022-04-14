using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //힘을 가하기
        //if(Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        //}

        //Vector3 vec = new Vector3(
        //    Input.GetAxisRaw("Horizontal"), 
        //    0, Input.GetAxisRaw("Vertical"));

        //rigid.AddForce(vec, ForceMode.Impulse);

        //회전력
        rigid.AddTorque(Vector3.up);
    }
}
