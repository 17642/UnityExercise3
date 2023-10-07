using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;//재질 접근
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)//물체가 충돌했을 때 실행
    {
        if (collision.gameObject.name == "My Ball")//MyBall 오브젝트와 충돌했을 때
            mat.color = new Color(0, 0, 0);//색상을 검정색으로 변경
        //Color는 기본 색상 클래스, Color32는 256색
    }

    private void OnCollisionExit(Collision collision)//물체의 충돌이 끝났을 때(떨어졌을 때) 실행
    {
        if (collision.gameObject.name == "My Ball") 
            mat.color = new Color(1, 1, 1);
    }

    //private void OnCollisionStay(Collision collision)//물체의 충돌이 진행 중일 떄(닿아 있을 때) 실행
    //{}
}
