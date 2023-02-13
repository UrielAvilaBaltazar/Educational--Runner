using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo3 : MonoBehaviour
{

    public GameObject BIndigo;
    public GameObject BVerde;
    public GameObject BAzul;

    public GameObject luz;
    public Transform posIndigo;
    public Transform posVerde;
    public Transform posAzul;
    bool indigo = false;
    bool verde = false;
    bool azul = false;

    // Start is called before the first frame update
    void Start()
    {
        var NR = Random.Range(0, 3);

        if (NR == 0)
        {
            indigo = true;
        }
        if (NR == 1)
        {
            verde = true;
        }
        if (NR == 2)
        {
            azul = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (indigo == true)
        {
            luz.transform.position = posIndigo.position;
            luz.GetComponent<Light>().color = new Color32(0, 255, 255, 255);
            BIndigo.SetActive(false);
            BVerde.SetActive(true);
            BAzul.SetActive(true);
        }

        if (verde == true)
        {
            luz.transform.position = posVerde.position;
            luz.GetComponent<Light>().color = Color.green;
            BIndigo.SetActive(true);
            BVerde.SetActive(false);
            BAzul.SetActive(true);
        }

        if (azul == true)
        {
            luz.transform.position = posAzul.position;
            luz.GetComponent<Light>().color = Color.blue;
            BIndigo.SetActive(true);
            BVerde.SetActive(true);
            BAzul.SetActive(false);
        }
    }
}
