using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 80f;
    public float impactforce = 30.0f;
    public Camera FpsCam;
    public ParticleSystem muzzleflash;
    public GameObject ImpactEffect;
    public TextMeshProUGUI Contador;
    public TextMeshProUGUI Contador2;
    public TextMeshProUGUI Ammo;
    public TextMeshProUGUI Ganar1;
    public TextMeshProUGUI Ganar2;
    public TextMeshProUGUI Ganar3;
    public TextMeshProUGUI GanarAbs;
    private int contador;
    private int contador2;
    private int contadorammo = 13;
    private bool approved1;
    private bool approved2;

    void Start() 
    {
        setContador();
        setContador2();
        setAmmo();
        Ganar1.text = "";
        Ganar2.text = "";
        Ganar3.text = "";
        GanarAbs.text = "";
        approved1 = false;
        approved2 = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && contadorammo>0)
        {
            Disparar();
        }
        if (Input.GetKeyDown(KeyCode.R) && contadorammo<13)
        {
            Recargar();
        }
        if(approved1 && approved2)
        {
            GanarAbs.text = "Ganaste el juego";
        }
    }
    void Disparar()
    {
        muzzleflash.Play();



        RaycastHit hit;
        if (Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            contadorammo = contadorammo - 1;
            setAmmo();
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                contador = contador + 1;
                target.takeDamage(damage);
                setContador();
                setAmmo();
            }

            Enemigo enemigo = hit.transform.GetComponent<Enemigo>();
            if (enemigo != null)
            {
                enemigo.takeDamage(damage);
                contador2 = contador2 + 1;
                setContador2();
                setAmmo();
            }

            if (hit.rigidbody != null)
            {
                setAmmo();
                hit.rigidbody.AddForce(-hit.normal * impactforce);
            }

            GameObject impact = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);

        }
    }

    void Recargar()
    {
        contadorammo = 13;
        setAmmo();
    }

    void setContador()
    {
        //Modificar contador
        Contador.text = "Targets destruidos: " + contador.ToString();
        //Si el jugador colecciona 8 monedas, desplegar mensaje de ganar
        if (contador == 15)
        {
            Ganar1.text = "Aprobado!";
        }
    }

    void setContador2()
    {
        Contador2.text = "Enemigos abatidos: " + contador2.ToString();
        if(contador2 == 30)
        {
            Ganar2.text = "Aprobado!";
        }
    }

    void setAmmo()
    {
        Ammo.text = "Munición: " + contadorammo.ToString();
    }


    private void OnTriggerEnter(Collider other)
    {
        //Si el objeto recoge una moneda
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            //Desactivar moneda y aumentar contador
            Ganar3.text = "Aprobado!";
        }
    }

    private void ReloadGun()
    {
        contadorammo = 13;
        setAmmo();
    }
}
