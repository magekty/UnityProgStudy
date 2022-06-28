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
        // isKinematic : 물리적인 영향을 받지 않도록 설정하는 기능
        // isKinematic가 false가 되면 물리적인 영향을 받도록 설정하는 것
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
