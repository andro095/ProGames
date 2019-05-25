using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsciacionLado : MonoBehaviour
{
    //Parametros para osilacion de lado
    public float height = 0.7f;
    public float speed = 1.0f;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Crear vector con la posicion inicial
        Vector3 v = startPos;
        //Funcion de seno para que los valores sean repetitivos
        v.x += height * Mathf.Sin(Time.time * speed);
        //Cambiar de posicion al objeto
        transform.position = v;
    }
}
