using UnityEngine.SceneManagement;
using UnityEngine;


public class Win_Animal : MonoBehaviour
{
    PlayerMovement playerMovement;

    // Start is called before the first frame update
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
        SceneManager.LoadScene(17);
    }
}
