using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat6 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject B2;
    public GameObject B5;
    public GameObject B1;
    //eleccion 
    bool dos = false;
    bool cinco = false;
    bool uno = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            dos = true;
        }
        if (NR == 1)
        {
            cinco = true;
        }
        if (NR == 2)
        {
            uno = true;
        }


    }

    void Update()
    {
        if (dos == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            B2.SetActive(true);
            B5.SetActive(false);
            B1.SetActive(false);
        }

        if (cinco == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            B2.SetActive(false);
            B5.SetActive(true);
            B1.SetActive(false);
        }

        if (uno == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            B2.SetActive(false);
            B5.SetActive(false);
            B1.SetActive(true);
        }
    }
}
