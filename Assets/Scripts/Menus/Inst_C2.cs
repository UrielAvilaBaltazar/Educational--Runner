using UnityEngine.SceneManagement;
using UnityEngine;

public class Inst_C2 : MonoBehaviour
{
    // Start is called before the first frame update
    int random;
    public void N_Color()
    {
        random = Random.Range(0, 2);
        if (random == 0)
        {
            SceneManager.LoadScene(10);
        }
        else if (random == 1)
        {
            SceneManager.LoadScene(11);
        }

    }
}
