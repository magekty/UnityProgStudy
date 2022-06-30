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
    // OnBecameInvisible : 게임 오브젝트가 화면 밖으로 이동했을때 동작하는 함수
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
