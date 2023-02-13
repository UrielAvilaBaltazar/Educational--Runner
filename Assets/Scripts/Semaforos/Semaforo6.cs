using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo6 : MonoBehaviour
{

    public GameObject BMorado;
    public GameObject BIndigo;
    public GameObject BVerde;

    public GameObject luz;
    public Transform posMorado;
    public Transform posIndigo;
    public Transform posVerde;
    bool morado = false;
    bool indigo = false;
    bool verde = false;

    // Start is called before the first frame update
    void Start()
    {
        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            morado = true;
        }
        if (NR == 1)
        {
            indigo = true;
        }
        if (NR == 2)
        {
            verde = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (morado == true)
        {
            luz.transform.position = posMorado.position;
            luz.GetComponent<Light>().color = Color.magenta;
            BMorado.SetActive(false);
            BIndigo.SetActive(true);
            BVerde.SetActive(true);
        }

        if (indigo == true)
        {
            luz.transform.position = posIndigo.position;
            luz.GetComponent<Light>().color = new Color32(0, 255, 255, 255);
            BMorado.SetActive(true);
            BIndigo.SetActive(false);
            BVerde.SetActive(true);
        }

        if (verde == true)
        {
            luz.transform.position = posVerde.position;
            luz.GetComponent<Light>().color = Color.green;
            BMorado.SetActive(true);
            BIndigo.SetActive(true);
            BVerde.SetActive(false);
        }
    }
}
