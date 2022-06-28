using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // �Է� �����ڿ��� Mouse ScrollWheel�� ���� ������ ����
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;

        // Clamp : �ּڰ��� �ִ��� �����ϰ� �����ϴ� �Լ�
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, 20, 60);

        mainCamera.fieldOfView += distance;
    }
}
