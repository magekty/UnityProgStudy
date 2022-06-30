using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab;

    public void GenericCreate()
    {
        // Instantiate : 게임 오브젝트를 생성하는 함수
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }

    public void PoolCreate()
    {
        ObjectPool.objpool.GetQueue();
    }

}
