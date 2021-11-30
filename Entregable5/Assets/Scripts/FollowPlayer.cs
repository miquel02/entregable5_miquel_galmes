using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(49.2f, 3.7f, 21.2f);
   
    // Indicamos a la camara que siga al player
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
