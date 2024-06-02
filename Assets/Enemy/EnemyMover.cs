using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
     float waitTime = 1f;
    void Start()
    {
        Debug.Log("Start here");
        StartCoroutine(FollowPath());
        Debug.Log("Finishing Start");
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }

    
}
