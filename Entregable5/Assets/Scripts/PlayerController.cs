using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float turnSpeed = 20f;
    public float verticalInput;
    private float zMax = 450f;

    //Hacemos que el player empieze en 0,0,0
    void Start()
    {
        transform.position = Vector3.zero;
    }

    //Le indicamos al player como moverse y el limite del mapa
    void Update()
    {
        if (transform.position.z > zMax)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);
    }
}
