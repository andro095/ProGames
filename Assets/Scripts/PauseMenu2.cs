using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu2 : MonoBehaviour
{
    private bool isPause = false;
    public GameObject gun;
    public GameObject scope;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause) Pause();
        }
    }
    public void Pause()
    {
        gun.SetActive(false);
        scope.SetActive(false);
        transform.Find("PauseMenu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPause = true;
       
    }

    public void Continue()
    {
        gun.SetActive(true);
        scope.SetActive(true);
        transform.Find("PauseMenu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPause = false;
        
    }
    public void CambiarEscena(string _newScene)
    {
        SceneManager.LoadScene(_newScene);
    }
}
