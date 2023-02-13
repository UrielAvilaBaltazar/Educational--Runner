using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner2 : MonoBehaviour
{
    [SerializeField] GameObject groundTile2;
    Vector3 nextSpawnPoint;

    public void SpawnTile2(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (spawnItems)
        {
            temp.GetComponent<GroundTile2>().SpawnObstacle();
            temp.GetComponent<GroundTile2>().SpawnCoins();
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile2(false);
            }
            else
            {
                SpawnTile2(true);
            }
        } 
    }
}
