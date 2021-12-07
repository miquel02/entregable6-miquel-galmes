using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 5f;

    private float upperLim = 10f;
    private float lowerLim = -10f;
    private float leftLim = -15f;
    private float rightLim = 15f;


    void Update()
    {
        //determinam sa direcció i velocitat de sa bala
        transform.Translate(Vector3.up * speed * Time.deltaTime);


        //feim que sa bala deseperesqui quan surt de sa pantalla
        if (transform.position.y > upperLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < lowerLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > rightLim)
        {
            Destroy(gameObject);
        }
    }
}
