using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSpawner : MonoBehaviour
{
    [SerializeField] GameObject buildTile;
    Vector3 nextSpawnPoint;

    public void BuildTile(bool spawnBuilds)
    {
        GameObject temp = Instantiate(buildTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (spawnBuilds)
        {
            temp.GetComponent<BuildTile>().SpawnEdd();
        }

    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                BuildTile(false);
            }
            else
            {
                BuildTile(true);
            }
        }
    }
}
