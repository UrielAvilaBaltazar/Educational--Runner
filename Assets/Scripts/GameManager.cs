using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;


    [SerializeField] Text scoreText;
    [SerializeField] Text FscoreText;

    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore()
    {
        //x = GameObject.FindObjectOfType<PlayerMovement>();
        score++;
        scoreText.text = "Monedas: " + score;
        FscoreText.text = "Monedas obtenidas: " + score;
        //aumenta la velocidad del jugador
        playerMovement.speed += playerMovement.speedIncreasePerPoint;

        if (score == 100)
        {
            win();
        }
    }

    public  void win()
    {
        SceneManager.LoadScene(22);
    }

    private void Awake ()
    {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
