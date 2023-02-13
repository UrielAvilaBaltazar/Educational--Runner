using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo2 : MonoBehaviour
{

    //semaforo 2
    public GameObject BAmarillo;
    public GameObject BNaranja;
    public GameObject BRojo;
    public GameObject luz2;
    public Transform posAmarilla2;
    public Transform posNaranja;
    public Transform posRojo;
    bool amarilla2 = false;
    bool naranja = false;
    bool rojo = false;

    // Start is called before the first frame update
    void Start()
    {
        var NR2 = Random.Range(0, 3);

        if (NR2 == 0)
        {
            amarilla2 = true;
        }
        if (NR2 == 1)
        {
            naranja = true;
        }
        if (NR2 == 2)
        {
            rojo = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (amarilla2 == true)
        {
            luz2.transform.position = posAmarilla2.position;
            luz2.GetComponent<Light>().color = Color.yellow;
            BAmarillo.SetActive(false);
            BNaranja.SetActive(true);
            BRojo.SetActive(true);
        }

        if (naranja == true)
        {
            luz2.transform.position = posNaranja.position;
            luz2.GetComponent<Light>().color = new Color32(243, 119, 8, 255);
            BAmarillo.SetActive(true);
            BNaranja.SetActive(false);
            BRojo.SetActive(true);
        }

        if (rojo == true)
        {
            luz2.transform.position = posRojo.position;
            luz2.GetComponent<Light>().color = Color.red;
            BAmarillo.SetActive(true);
            BNaranja.SetActive(true);
            BRojo.SetActive(false);
        }
    }
}
