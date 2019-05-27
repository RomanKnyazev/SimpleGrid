using UnityEngine;
using System.Collections.Generic;

namespace Assets
{
    public sealed class RaycastSpawner : MonoBehaviour
    { 
        [SerializeField] private int _gridCellLayer = 5;
        [SerializeField] private GameObject _prefab;
        private void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (!Physics.Raycast(ray, out RaycastHit hit, 100.0f)) return;
                if (hit.transform.gameObject.layer == _gridCellLayer)//layer 11(TurretLayer)
                {
                    Instantiate(_prefab, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}