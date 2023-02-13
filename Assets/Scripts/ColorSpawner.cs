using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSpawner : MonoBehaviour
{

    [SerializeField] GameObject colorTile;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    public void ColorTile(bool spawnItems)
    {
        GameObject temp = Instantiate(colorTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }
    
    // Update is called once per frame
    private void Start()
    {
        ColorTile(true);
        /*
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                ColorTile(false);
            }
            else
            {
                ColorTile(true);
            }
        }*/
    }
}
    
