
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_GO : MonoBehaviour
{
    //public MenuNiveles X;
    //X = FindObjectOfType<MenuNiveles>();
    [SerializeField]
    public GameObject game;
    int x;

    public void Volver()
    {
        x = Random.Range(8, 10);

        SceneManager.LoadSceneAsync(x);
        game.SetActive(false);

    } 

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}
