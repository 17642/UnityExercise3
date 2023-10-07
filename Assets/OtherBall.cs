using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;//���� ����
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)//��ü�� �浹���� �� ����
    {
        if (collision.gameObject.name == "My Ball")//MyBall ������Ʈ�� �浹���� ��
            mat.color = new Color(0, 0, 0);//������ ���������� ����
        //Color�� �⺻ ���� Ŭ����, Color32�� 256��
    }

    private void OnCollisionExit(Collision collision)//��ü�� �浹�� ������ ��(�������� ��) ����
    {
        if (collision.gameObject.name == "My Ball") 
            mat.color = new Color(1, 1, 1);
    }

    //private void OnCollisionStay(Collision collision)//��ü�� �浹�� ���� ���� ��(��� ���� ��) ����
    //{}
}
