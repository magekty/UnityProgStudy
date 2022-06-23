using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // 자료구조 Queue 사용 - 선입선출 First In First Out
    // static : 게임이 종료될 때 까지 메모리에 남음

    public static ObjectPool objpool;

    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    private void Start()
    {
        objpool = this;

        for(int i = 0; i < 5; i++)
        {
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);
        }
    }

    public void InsertQueue(GameObject tObject)
    {
        queue.Enqueue(tObject);
        tObject.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempObject = queue.Dequeue();
        tempObject.SetActive(true);

        return tempObject;
    }

}
