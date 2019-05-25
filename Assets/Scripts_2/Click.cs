using UnityEngine;
using System;
using System.Collections;

    public class Click : MonoBehaviour
{
    public float force = 20;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {

                    Rigidbody rb;

                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        PrintName(hit.transform.gameObject);
                        LaunchIntoAir(rb);
                    }
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void LaunchIntoAir(Rigidbody rig)
    {
        rig.AddForce(rig.transform.forward * force, ForceMode.Force);
    }


}
