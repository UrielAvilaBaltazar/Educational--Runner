using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_GO3 : MonoBehaviour
{
    [SerializeField]
    public GameObject game;
    int x;

    public void Volver()
    {
        x = Random.Range(12, 14);

        SceneManager.LoadSceneAsync(x);
        game.SetActive(false);

    }

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}
