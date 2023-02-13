using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner3 : MonoBehaviour
{
    [SerializeField] GameObject groundTile3;
    Vector3 nextSpawnPoint;

    public void SpawnTile3(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile3, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (spawnItems)
        {
            temp.GetComponent<GroundTile3>().SpawnObstacle3();
            temp.GetComponent<GroundTile3>().SpawnCoins3();
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile3(false);
            }
            else
            {
                SpawnTile3(true);
            }
        }
    }
}
