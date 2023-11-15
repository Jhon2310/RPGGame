using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    private Camera _camera;
    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _camera = Camera.main;
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        
        var ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out var hitInfo))
        {
            _destination = hitInfo.point;
            if (Input.GetMouseButton(0))
            {
                _navMeshAgent.SetDestination(_destination);
            }
            
        }
        // TODO: Получите точку, по которой кликнули мышью и задайте ее вектор в поле _destination.
    }
}