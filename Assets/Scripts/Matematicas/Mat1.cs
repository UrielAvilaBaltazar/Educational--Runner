using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat1 : MonoBehaviour
{
    // Start is called before the first frame update
    //barreras
    public GameObject BX;
    public GameObject BY;
    public GameObject BZ;
    //operaciones
    public GameObject BCinco;
    public GameObject BNueve;
    public GameObject BTres;
    //eleccion 
    bool cinco = false;
    bool nueve = false;
    bool tres = false;

    private void Start()
    {

        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            cinco = true;
        }
        if (NR == 1)
        {
            nueve = true;
        }
        if (NR == 2)
        {
            tres = true;
        }
        

    }

    void Update()
    {
        if (cinco == true)
        {
            //activar barreras
            BX.SetActive(false);
            BY.SetActive(true);
            BZ.SetActive(true);
            //activar operacion
            BCinco.SetActive(true);
            BNueve.SetActive(false);
            BTres.SetActive(false);
        }

        if (nueve == true)
        {
            BX.SetActive(true);
            BY.SetActive(false);
            BZ.SetActive(true);

            BCinco.SetActive(false);
            BNueve.SetActive(true);
            BTres.SetActive(false);
        }

        if (tres == true)
        {
            BX.SetActive(true);
            BY.SetActive(true);
            BZ.SetActive(false);

            BCinco.SetActive(false);
            BNueve.SetActive(false);
            BTres.SetActive(true);
        }
    }
}
