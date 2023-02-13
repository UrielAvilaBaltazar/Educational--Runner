using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat2 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject B7;
    public GameObject B4;
    public GameObject B8;
    //eleccion 
    bool siete = false;
    bool cuatro = false;
    bool ocho = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            siete = true;
        }
        if (NR == 1)
        {
            cuatro = true;
        }
        if (NR == 2)
        {
            ocho = true;
        }


    }

    void Update()
    {
        if (siete == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            B7.SetActive(true);
            B4.SetActive(false);
            B8.SetActive(false);
        }

        if (cuatro == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            B7.SetActive(false);
            B4.SetActive(true);
            B8.SetActive(false);
        }

        if (ocho == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            B7.SetActive(false);
            B4.SetActive(false);
            B8.SetActive(true);
        }
    }
}
