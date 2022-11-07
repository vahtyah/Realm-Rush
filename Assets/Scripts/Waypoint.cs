using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefabs;
    [SerializeField] bool isPlaceable;
    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(towerPrefabs, transform.position, Quaternion.identity);
            isPlaceable = false;
        }
    }
    public bool IsPlaceable { get => isPlaceable; }
}
