using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab;

    public void GenericCreate()
    {
        // Instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
