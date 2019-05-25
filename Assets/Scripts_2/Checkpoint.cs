using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Checkpoint : MonoBehaviour
{
    public Text GanarObs;
    private bool approved2;

    // Start is called before the first frame update
    void Start()
    {
        GanarObs.text = "";
        approved2 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        approved2 = true;
        GanarObs.text = "APPROVED";
    }
}
