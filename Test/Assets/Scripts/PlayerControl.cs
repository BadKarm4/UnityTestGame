using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;

    private void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0) 
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit) || Physics.Raycast(mainCamera.ScreenPointToRay(Input.GetTouch(0).position), out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
