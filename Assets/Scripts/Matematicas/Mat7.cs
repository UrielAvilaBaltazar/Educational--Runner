using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat7 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject B6;
    public GameObject B8;
    public GameObject B3;
    //eleccion 
    bool seis = false;
    bool ocho = false;
    bool tres = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            seis = true;
        }
        if (NR == 1)
        {
            ocho = true;
        }
        if (NR == 2)
        {
            tres = true;
        }


    }

    void Update()
    {
        if (seis == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            B6.SetActive(true);
            B8.SetActive(false);
            B3.SetActive(false);
        }

        if (ocho == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            B6.SetActive(false);
            B8.SetActive(true);
            B3.SetActive(false);
        }

        if (tres == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            B6.SetActive(false);
            B8.SetActive(false);
            B3.SetActive(true);
        }
    }
}
