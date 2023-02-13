
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Salida : MonoBehaviour
{
   public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        // Application.Quit();
    }
}
