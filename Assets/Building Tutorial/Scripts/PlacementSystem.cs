using UnityEngine;

namespace Building_Tutorial.Scripts
{
    public class PlacementSystem : MonoBehaviour
    {
        [SerializeField] private GameObject cellIndicator;
        [SerializeField] private InputManager inputManager;
        [SerializeField] private Grid grid;

        private void Update()
        {
            Vector3 mousePosition = inputManager.GetSelectedMousePosition();
            Vector3Int gridPosition = grid.WorldToCell(mousePosition);
            cellIndicator.transform.position = grid.CellToWorld(gridPosition);
        }
    }
}
 