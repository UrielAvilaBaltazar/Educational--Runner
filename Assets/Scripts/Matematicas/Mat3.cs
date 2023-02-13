using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat3 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject B1;
    public GameObject B8;
    public GameObject B10;
    //eleccion 
    bool uno = false;
    bool ocho = false;
    bool diez = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            uno = true;
        }
        if (NR == 1)
        {
            ocho = true;
        }
        if (NR == 2)
        {
            diez = true;
        }


    }

    void Update()
    {
        if (uno == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            B1.SetActive(true);
            B8.SetActive(false);
            B10.SetActive(false);
        }

        if (ocho == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            B1.SetActive(false);
            B8.SetActive(true);
            B10.SetActive(false);
        }

        if (diez == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            B1.SetActive(false);
            B8.SetActive(false);
            B10.SetActive(true);
        }
    }
}
