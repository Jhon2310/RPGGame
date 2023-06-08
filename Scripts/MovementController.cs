using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    private Bridge _bridge;
    
    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out var hitInfo,50f))
        {
            if (Input.GetMouseButton(0))
            {
                var point = hitInfo.point;
                _navMeshAgent.SetDestination(_destination+point);
               
            }
        }
        // TODO: Получите точку, по которой кликнули мышью и задайте ее вектор в поле _destination.
    }
}