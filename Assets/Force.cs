using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    Rigidbody rigid;//����

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();//�ʱ�ȭ. Rigidbody�� ������Ʈ�� ������
        //rigid.velocity = Vector3.right;
        //rigid.velocity = new Vector3(2, 4, 3);//��ü�� �ӵ��� ����
        //rigid.AddForce(Vector3.up*5,ForceMode.Impulse);//��ü�� ���� ����. ���԰� Ŭ ���� �� ū ���� �ʿ�.
    }

    // Update is called once per frame
    void Update()
    {
        //rigid.velocity = new Vector3(2, 4, 3);//Update�� �����ϸ� ���������� ���� �޾� �̵���.
    }

    private void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, 3);//���� ���� �Լ��� FixedUpdate�� ����

        if(Input.GetButtonDown("Jump"))//Jump Ű�� ������
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);//�� �������� 5�� ���� ����.(����)
        //Debug.Log(rigid.velocity);//�ӷ� ǥ��
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec,ForceMode.Impulse);//���� ���ؼ� �̵�.

        //ȸ����//

        //rigid.AddTorque(Vector3.down);//������
        //���͸� ������ �ؼ� ȸ����.
        



    }
}
