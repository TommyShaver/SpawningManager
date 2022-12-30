using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xRange = 10.0f;
    public GameObject pizzaPrefab;
    public float zBottomCam = 0.0f;
    public float zTopCam = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Stay in bounds of world =================================================================
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.z < zBottomCam)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBottomCam);
        }
        if (transform.position.z > zTopCam)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTopCam);
        }
        //Movement ==================================================================================
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.forward);


        //How to shoot a weapon =====================================================================
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pizzaPrefab, transform.position, pizzaPrefab.transform.rotation);
        }
    }
}
