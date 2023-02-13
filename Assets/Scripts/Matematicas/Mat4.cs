using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat4 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject B3;
    public GameObject B7;
    public GameObject B6;
    //eleccion 
    bool tres = false;
    bool siete = false;
    bool seis = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            tres = true;
        }
        if (NR == 1)
        {
            siete = true;
        }
        if (NR == 2)
        {
            seis = true;
        }


    }

    void Update()
    {
        if (tres == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            B3.SetActive(true);
            B7.SetActive(false);
            B6.SetActive(false);
        }

        if (siete == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            B3.SetActive(false);
            B7.SetActive(true);
            B6.SetActive(false);
        }

        if (seis == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            B3.SetActive(false);
            B7.SetActive(false);
            B6.SetActive(true);
        }
    }
}
