using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MyBall : MonoBehaviour
{

    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec,ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name=="EnterCube")
            rigid.AddForce(Vector3.up*5,ForceMode.Impulse);
    }
}
