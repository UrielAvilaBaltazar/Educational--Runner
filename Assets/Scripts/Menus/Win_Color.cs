using UnityEngine.SceneManagement;
using UnityEngine;

public class Win_Color : MonoBehaviour
{
    PlayerMovement playerMovement;
    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //perder
            ganar();
        }
    }
    public void ganar()
    {
        SceneManager.LoadScene(18);
    }
}
