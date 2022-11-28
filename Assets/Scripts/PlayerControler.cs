using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 10f;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 16f;
    public GameObject projectailePrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        PlayerInBound();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

    private void PlayerInBound()
    {
        Vector3 pos = transform.position;
        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
       
    }
    private void FireProjectile()
    {
        Instantiate(projectailePrefab, transform.position, Quaternion.identity);
    }
}
