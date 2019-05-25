using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilacion : MonoBehaviour
{
    //Parametros para el objeto
    public float height = 0.7f;
    public float speed = 1.0f;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        //Posicion inicial
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Crear vector con la posicion inicial
        Vector3 v = startPos;
        //Funcion de seno para que los valores sean repetitivos
        v.y += height * Mathf.Sin(Time.time * speed);
        //Cambiar de posicion al objeto
        transform.position = v;
    }
}
