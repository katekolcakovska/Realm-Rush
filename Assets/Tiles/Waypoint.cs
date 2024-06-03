using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceble;

    public bool GetIsPlaceble()
    {
        return isPlaceble;
    }
    void OnMouseDown()
    {
        if(isPlaceble)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceble = false;
        }
        
    }


}
