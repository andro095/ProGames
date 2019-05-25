using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //Parametros para la clase de respawn
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    //Defnir punto de respawn para el objeto
    void OnTriggerEnter(Collider other)
    {
        //Cambiar de posicion el objeto en caso choque con un obstaculo
        player.transform.position = respawnPoint.transform.position;
    }
}
