using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets{
public sealed class GridManager : MonoBehaviour
{
    [SerializeField] private Transform gridPrefab;
    [SerializeField] private int rows = 2;
    [SerializeField] private int columns = 2;
    private void Start()
    {
        for (int r = -rows; r < rows; r++)
        {
            for (int c = -columns; c < columns; c++)
            {
                var celltransform = new Vector3(r + 1.5f, 0, c + 0.5f);
                Instantiate(gridPrefab, celltransform, Quaternion.identity);
            }
        }
    }
}
}