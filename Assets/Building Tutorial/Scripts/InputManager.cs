using UnityEngine;

namespace Building_Tutorial.Scripts
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private Camera sceneCamera;
        [SerializeField] private LayerMask placementLayerMask;

        private Vector3 _lastPosition;

        public Vector3 GetSelectedMousePosition()
        {
            float maxDistance = 100f;
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = sceneCamera.ScreenPointToRay(mousePosition);
        
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, placementLayerMask))
            {
                _lastPosition = hit.point;
                Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.green);
            }
        
            return _lastPosition;
        }
    }
}
