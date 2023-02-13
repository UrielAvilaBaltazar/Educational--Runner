using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo5 : MonoBehaviour
{
    public GameObject BRojo;
    public GameObject BAzul;
    public GameObject BAmarillo;

    public GameObject luz;
    public Transform posRojo;
    public Transform posAzul;
    public Transform posAmarillo;
    bool rojo = false;
    bool azul = false;
    bool amarillo = false;

    // Start is called before the first frame update
    void Start()
    {
        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            rojo = true;
        }
        if (NR == 1)
        {
            azul = true;
        }
        if (NR == 2)
        {
            amarillo = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rojo == true)
        {
            luz.transform.position = posRojo.position;
            luz.GetComponent<Light>().color = Color.red;
            BRojo.SetActive(false);
            BAzul.SetActive(true);
            BAmarillo.SetActive(true);
        }

        if (azul == true)
        {
            luz.transform.position = posAzul.position;
            luz.GetComponent<Light>().color = Color.blue;
            BRojo.SetActive(true);
            BAzul.SetActive(false);
            BAmarillo.SetActive(true);
        }

        if (amarillo == true)
        {
            luz.transform.position = posAmarillo.position;
            luz.GetComponent<Light>().color = Color.yellow;
            BRojo.SetActive(true);
            BAzul.SetActive(true);
            BAmarillo.SetActive(false);
        }
    }
}
