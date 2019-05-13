using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarEscen(string _newScene)
    {
        SceneManager.LoadScene(_newScene);
    }
}
