using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo4 : MonoBehaviour
{
    public GameObject BVerde;
    public GameObject BRojo;
    public GameObject BNaranja;

    public GameObject luz;
    public Transform posVerde;
    public Transform posRojo;
    public Transform posAmarillo;
    bool verde = false;
    bool rojo = false;
    bool amarillo = false;

    // Start is called before the first frame update
    void Start()
    {
        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            verde = true;
        }
        if (NR == 1)
        {
            rojo = true;
        }
        if (NR == 2)
        {
            amarillo = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (verde == true)
        {
            luz.transform.position = posVerde.position;
            luz.GetComponent<Light>().color = Color.green;
            BVerde.SetActive(false);
            BRojo.SetActive(true);
            BNaranja.SetActive(true);
        }

        if (rojo == true)
        {
            luz.transform.position = posRojo.position;
            luz.GetComponent<Light>().color = Color.red;
            BVerde.SetActive(true);
            BRojo.SetActive(false);
            BNaranja.SetActive(true);
        }

        if (amarillo == true)
        {
            luz.transform.position = posAmarillo.position;
            luz.GetComponent<Light>().color = new Color32(255, 107, 0, 255);
            BVerde.SetActive(true);
            BRojo.SetActive(true);
            BNaranja.SetActive(false);
        }
    }
}
