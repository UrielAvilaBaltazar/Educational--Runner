using UnityEngine.SceneManagement;
using UnityEngine;

public class Inst_M2 : MonoBehaviour
{
    int random;
    public void N_Mate()
    {
        random = Random.Range(0, 2);
        if (random == 0)
        {
            SceneManager.LoadScene(12);
        }
        else if (random == 1)
        {
            SceneManager.LoadScene(13);
        }

    }
}
