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
        // 입력 관리자에서 Mouse ScrollWheel에 대한 정보를 저장
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;

        // Clamp : 최솟값과 최댓값을 지정하고 제한하는 함수
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, 20, 60);

        mainCamera.fieldOfView += distance;
    }
}
