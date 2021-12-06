using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30f;

    private float upperLimit = 12f;
    private float lowerLimit = -12f;
    private float rightLimit = 12f;
    private float leftLimit = -12f;

    void Update()
    {
        //El Objeto se movera hacia delante de forma constante a la velocidad que le hemos asignado

        transform.Translate(Vector3.up * speed * Time.deltaTime);

        //El proyectil se destruira si cumple alguna de las 4 condiciones que se le ha impuesto a continuacion

        if (transform.position.y > upperLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
