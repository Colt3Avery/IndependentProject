using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 Offset = new Vector3(7, 3, 0);
   


    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + Offset;
    }
}
