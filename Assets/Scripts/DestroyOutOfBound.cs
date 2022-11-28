using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    //Limite de mapa
    private float upperLimit = 20f;
    private float lowerLimit = -10f;
    private void Update()
    {
        if (transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
