using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // RaycastHit : ������ �浹�� ������Ʈ�� ���� ������ ����
            RaycastHit hit;

            // ī�޶�κ��� ��ũ�� ������ ���콺����Ʈ�� ���� ��ġ������ ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }
        }
    }

    public void Move(Vector3 Position)
    {
        agent.speed = speed;
        agent.SetDestination(Position);
    }
}
