using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    Rigidbody rigid;//선언

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();//초기화. Rigidbody의 컴포넌트를 가져옴
        //rigid.velocity = Vector3.right;
        //rigid.velocity = new Vector3(2, 4, 3);//물체의 속도를 설정
        //rigid.AddForce(Vector3.up*5,ForceMode.Impulse);//물체에 힘을 가함. 무게가 클 수록 더 큰 힘이 필요.
    }

    // Update is called once per frame
    void Update()
    {
        //rigid.velocity = new Vector3(2, 4, 3);//Update에 설정하면 지속적으로 힘을 받아 이동함.
    }

    private void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, 3);//물리 관련 함수는 FixedUpdate에 설정

        if(Input.GetButtonDown("Jump"))//Jump 키를 누르면
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);//위 방향으로 5의 힘을 가함.(점프)
        //Debug.Log(rigid.velocity);//속력 표시
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec,ForceMode.Impulse);//힘을 가해서 이동.

        //회전력//

        //rigid.AddTorque(Vector3.down);//돌리기
        //벡터를 축으로 해서 회전함.
        



    }
}
