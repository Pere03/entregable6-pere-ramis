using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Quaternion Rotation;
    public GameObject SpawnProjectile;
  
    void Update()
    {
        //Con esto hacemos que si pulsamos la flecha de arriba, el proyectil se instanciara moviendose hacia arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rotation = Quaternion.Euler(0, 0, 0);
            Instantiate(SpawnProjectile, transform.position,
            SpawnProjectile.transform.rotation = Rotation);
        }

        //Con esto hacemos que si pulsamos la flecha de abajo, el proyectil se instanciara moviendose hacia abajo
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Rotation = Quaternion.Euler(180, 0, 0);
            Instantiate(SpawnProjectile, transform.position,
            SpawnProjectile.transform.rotation = Rotation);
        }

        //Con esto hacemos que si pulsamos la flecha derecha, el proyectil se instanciara moviendose hacia la derecha
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rotation = Quaternion.Euler(0, 0, -90);
            Instantiate(SpawnProjectile, transform.position,
            SpawnProjectile.transform.rotation = Rotation);
        }

        //Con esto hacemos que si pulsamos la flecha izquierda, el proyectil se instanciara moviendose hacia la izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rotation = Quaternion.Euler(0, 0, 90);
            Instantiate(SpawnProjectile, transform.position,
            SpawnProjectile.transform.rotation = Rotation);
        }
        
    }
}
