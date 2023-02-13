using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    public void EleNivel()
    {
        SceneManager.LoadScene(1);
    }
    public void Acerca()
    {
        SceneManager.LoadScene(20);
    }
    public void Salir()
    {
        SceneManager.LoadScene(21);
    }
}
