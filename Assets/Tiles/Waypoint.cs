using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;

    [SerializeField] bool isPlacable;
    public bool IsPlaceable { get { return isPlacable; } }



    void OnMouseDown()
    {
        if (isPlacable)
        {
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlacable = !isPlaced;
        }

    }
}
