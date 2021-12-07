using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject projectilePrefab;
     
  
    void Update()
    {
        //feim que la bala surti rotada
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 180));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, -90));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 90));
        }
    }

    //funció per cridar a la bala
    public void SpawnProjectile(Quaternion rotation)
    {
        Instantiate(projectilePrefab, transform.position, rotation);

    }

}
