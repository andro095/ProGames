using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject Pausa;
    [SerializeField] private bool enpausa;
    public string SceneToLoad;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            enpausa = !enpausa;
        }

        if (enpausa)
        {
            ActivarMenu();
        }

        else
        {
            DesactivarMenu();
        }

    }

    void ActivarMenu()
    {
        Time.timeScale = 0;
        Pausa.SetActive(true);
    }

    public void DesactivarMenu()
    {
        Time.timeScale = 1;
        Pausa.SetActive(false);
        enpausa = false;
    }

    public void Reiniciar(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);
    }

    public void Volver(string SceneToLoad2)
    {
        SceneManager.LoadScene(SceneToLoad2);
    }
}
