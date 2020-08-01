using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private WayPoints Wpoints;

    private int wayindex;

    // Start is called before the first frame update
    void Start()
    {
         Wpoints = GameObject.FindGameObjectWithTag("WayPoint").GetComponent<WayPoints>();
        //Wpoints = GetComponent<WayPoints>();     //........It call scripts Only If This Calling Script also attact with same GameObgect.
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[wayindex].position, speed * Time.deltaTime);

        //Rotate the player Towards forward direction
        Vector3 dir = Wpoints.waypoints[wayindex].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        if (Vector2.Distance(transform.position, Wpoints.waypoints[wayindex].position) < 0.1f)
        {
            if (wayindex < Wpoints.waypoints.Length - 1)
            {
                wayindex++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
