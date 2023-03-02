using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    
    public GameObject followPlayer;
    private Vector3 offSet = new Vector3( 0,5,-15 );
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate comes after Update
    void LateUpdate()
    {
        transform.position = followPlayer.transform.position + offSet ;
    }
}
