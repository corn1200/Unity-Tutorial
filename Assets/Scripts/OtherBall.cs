using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    Color originColor;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
        originColor = mat.color;
    }

    //실제 물리적 충돌 시작
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
            mat.color = new Color(0, 0, 0);
    }

    //실제 물리적 충돌 지속
    private void OnCollisionStay(Collision collision)
    {

    }

    //실제 물리적 충돌 종료
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            mat.color = originColor;
        }
    }
}
