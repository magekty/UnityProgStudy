using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    bool condition = false;
    public float speed;

    Rigidbody rigid;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        // 스페이스바를 눌렀을 때 && condition == true 실행

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            // AddForce : 객체에 일정한 힘을 가하는 함수
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중");
    }

    private void OnCollisionExit(Collision collision)
    {
        condition = false;
    }



    private void FixedUpdate()
    {
        rigid.MovePosition
            (
                rigid.position + dir.normalized * speed * Time.fixedDeltaTime
            );
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("트리거 활성");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 비활성");
    }

}
