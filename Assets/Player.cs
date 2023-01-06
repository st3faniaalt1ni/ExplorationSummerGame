using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    public float speed = 10f;
    public Transform mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += mainCamera.rotation * Vector3.forward * speed;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
}