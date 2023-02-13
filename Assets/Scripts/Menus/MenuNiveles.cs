using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{ 
    public bool Animal = false;
    public bool Color = false;
    [SerializeField] bool Mate = false;

    public void PC1()
    {
        SceneManager.LoadScene(2);
    }

    public void PC2()
    {
        //nivel colores
        Color = true;
        SceneManager.LoadScene(4);
        Color = false;
    }

    public void PC3()
    {
        //nivel matematicas
        SceneManager.LoadScene(6);
    }

}
