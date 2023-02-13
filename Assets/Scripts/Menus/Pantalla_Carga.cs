using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pantalla_Carga : MonoBehaviour
{
    //[SerializeField] private Slider BCarga;
    public void NivelAnimales()
    {
        SceneManager.LoadScene(14);
       // StartCoroutine(Cargando());
    }

 /*
    IEnumerator Cargando()
    {
       AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(2);

        while (!asyncOperation.isDone)
        {
            Debug.Log(asyncOperation.progress);
            BCarga.value = asyncOperation.progress;
            yield return null;
        }
    }*/
}
