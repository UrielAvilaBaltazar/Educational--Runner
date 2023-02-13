using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{
    //semaforo 1
    public GameObject BAzul;
    public GameObject BAmarillo;
    public GameObject BMorado;
    public GameObject luz;
    public Transform posAzul;
    public Transform posAmarilla;
    public Transform posMorado; 
    bool azul = false;
    bool amarilla = false;
    bool morado = false;

    private void Start()
    {
        
        /*
        Arreglo[0] = azul;
        Arreglo[1] = amarilla;
        Arreglo[2] = morado;
        */
        //semaforo 1
        var NR = Random.Range(0, 3);

        if (NR == 0){
            azul = true;
        }
        if (NR == 1)
        {
            amarilla = true;
        }
        if (NR == 2)
        {
            morado = true;
        }
        /*
        var element = Arreglo[NR];
        element = true;
        if element = 1{

        }
        */
        //semaforo 2

    }

    void Update()
    {
        //semaforo 1
        if(azul == true)
        {
            luz.transform.position = posAzul.position;
            luz.GetComponent<Light>().color = Color.blue;
            BAzul.SetActive(false);
            BAmarillo.SetActive(true);
            BMorado.SetActive(true);
          //  StartCoroutine(luzAzul());
            //azul = false;
        }

        if(amarilla == true)
        {
            luz.transform.position = posAmarilla.position;
            luz.GetComponent<Light>().color = Color.yellow;
            BAzul.SetActive(true);
            BAmarillo.SetActive(false);
            BMorado.SetActive(true);
            // StartCoroutine(luzAmarilla());
            //  amarilla = false;
        }

        if(morado == true)
        {
            luz.transform.position = posMorado.position;
            luz.GetComponent<Light>().color = Color.magenta;
            BAzul.SetActive(true);
            BAmarillo.SetActive(true);
            BMorado.SetActive(false);
            //StartCoroutine(luzMorada());
            // morado = false;
        }
    }
    /*
    IEnumerator luzAzul()
    {
        yield return new WaitForSeconds(2);
        amarilla = true;
    }

    IEnumerator luzAmarilla()
    {
        yield return new WaitForSeconds(2);
        morado = true;
    }

    IEnumerator luzMorada()
    {
        yield return new WaitForSeconds(2);
        azul = true;
    }*/
}
