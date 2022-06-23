using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneriecStoneDelete : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    // OnBecameInvisible : ���� ������Ʈ�� ȭ�� ������ �̵������� �����ϴ� �Լ�
    private void OnBecameInvisible()
    {
        if (gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject);
        }else if (gameObject.name == "Stone_5(Clone)")
        {
            rigid.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(0, 5, 0);
            ObjectPool.objpool.InsertQueue(gameObject);
        }
    }
}
