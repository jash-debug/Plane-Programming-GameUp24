using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //distance from plane
    private Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // LateUpdate is called once per frame after the update
    void LateUpdate()
    {
        //make position of camera to the plane with offset
        transform.position = plane.transform.position + offset;
    }
}
