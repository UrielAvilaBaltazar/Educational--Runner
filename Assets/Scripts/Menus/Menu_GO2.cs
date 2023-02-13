using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_GO2 : MonoBehaviour
{
    [SerializeField]
    public GameObject game;
    int x;

    public void Volver()
    {
        x = Random.Range(10, 12);

        SceneManager.LoadSceneAsync(x);
        game.SetActive(false);

    }

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}
