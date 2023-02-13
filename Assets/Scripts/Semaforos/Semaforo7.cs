using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo7 : MonoBehaviour
{
    public GameObject BAzul;
    public GameObject BAmarillo;
    public GameObject BRojo;

    public GameObject luz;
    public Transform posAzul;
    public Transform posAmarillo;
    public Transform posRojo;
    bool azul = false;
    bool amarillo = false;
    bool rojo = false;

    // Start is called before the first frame update
    void Start()
    {
        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            azul = true;
        }
        if (NR == 2)
        {
            rojo = true;
        }
        if (NR == 1)
        {
            amarillo = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (azul == true)
        {
            luz.transform.position = posAzul.position;
            luz.GetComponent<Light>().color = Color.blue;
            BAzul.SetActive(false);
            BAmarillo.SetActive(true);
            BRojo.SetActive(true);
        }
        if (amarillo == true)
        {
            luz.transform.position = posAmarillo.position;
            luz.GetComponent<Light>().color = Color.yellow;
            BAzul.SetActive(true);
            BAmarillo.SetActive(false);
            BRojo.SetActive(true);
        }

        if (rojo == true)
        {
            luz.transform.position = posRojo.position;
            luz.GetComponent<Light>().color = Color.red;
            BAzul.SetActive(true);
            BAmarillo.SetActive(true);
            BRojo.SetActive(false);
        }

        
    }
}
