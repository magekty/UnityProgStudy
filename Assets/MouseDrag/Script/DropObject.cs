using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject: MonoBehaviour
{
    private Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    private void OnMouseUp()
    {
        // isKinematic : �������� ������ ���� �ʵ��� �����ϴ� ���
        // isKinematic�� false�� �Ǹ� �������� ������ �޵��� �����ϴ� ��
        rigid.isKinematic = false;
    }

    private void OnMouseDrag()
    {
        rigid.isKinematic = true;

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, 
            Input.mousePosition.y, 
            Camera.main.WorldToScreenPoint(gameObject.transform.position).z);

        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
}
