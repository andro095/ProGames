using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavScript : MonoBehaviour
{
    public GameObject Enemigo;
    // Start is called before the first frame update
    void Start()
    {
        if (Enemigo)
            GetComponent<NavMeshAgent>().SetDestination(Enemigo.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
