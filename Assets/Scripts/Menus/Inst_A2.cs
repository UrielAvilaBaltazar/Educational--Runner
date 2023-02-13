using UnityEngine.SceneManagement;
using UnityEngine;

public class Inst_A2 : MonoBehaviour
{
    int random;
    public void N_Ani()
    {
        random = Random.Range(0, 2);
        if (random == 0)
        {
            SceneManager.LoadScene(8);
        } else if (random == 1)
        {
            SceneManager.LoadScene(9);
        }
        
    }
}
