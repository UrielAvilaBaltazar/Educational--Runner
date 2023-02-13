using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat5 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject B10;
    public GameObject B4;
    public GameObject B9;
    //eleccion 
    bool diez = false;
    bool cuatro = false;
    bool nueve = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            diez = true;
        }
        if (NR == 1)
        {
            cuatro = true;
        }
        if (NR == 2)
        {
            nueve = true;
        }


    }

    void Update()
    {
        if (diez == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            B10.SetActive(true);
            B4.SetActive(false);
            B9.SetActive(false);
        }

        if (cuatro == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            B10.SetActive(false);
            B4.SetActive(true);
            B9.SetActive(false);
        }

        if (nueve == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            B10.SetActive(false);
            B4.SetActive(false);
            B9.SetActive(true);
        }
    }
}
