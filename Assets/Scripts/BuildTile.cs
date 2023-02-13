using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTile : MonoBehaviour
{
    BuildSpawner buildSpawner;

    [SerializeField] GameObject[] Builds = new GameObject[14];
    [SerializeField] GameObject maya;
    [SerializeField] GameObject maya2;
    //  [SerializeField] GameObject BuildPrefab2;
    //[SerializeField] float tallObstacleChance = 0.2f;

    // Start is called before the first frame update
    private void Start()
    {
        buildSpawner = GameObject.FindObjectOfType<BuildSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        buildSpawner.BuildTile(true);
        Destroy(gameObject, 2);
    }

    public void SpawnEdd()
    {
        //Tiles[i] = GameObject.Instantiate(Resources.Load("Tile")) as GameObject;
        int x = Random.Range(0, Builds.Length);
        int y = Random.Range(0, Builds.Length);


        //elegir cual obstaculo aparrece
        GameObject barrera = maya;
        GameObject barrera2 = maya2;
        GameObject obstacleToSpawn = Builds[x];
        GameObject eddificio = Builds[y];
        //Generacion obstaculos

        //int obstacleSpawnIndex = Random.Range(2, 4);
        //edificios
        int obstacle = 2;
        Transform spawPoint = transform.GetChild(obstacle).transform;
        Instantiate(obstacleToSpawn, spawPoint.position, Quaternion.identity, transform);

        int obstacle2 = 3;
        Transform spawPoint2 = transform.GetChild(obstacle2).transform;
        Instantiate(eddificio, spawPoint2.position, Quaternion.identity, transform);

        //barreras
        int m1 = 4;
        Transform trans1 = transform.GetChild(m1).transform;
        Instantiate(barrera, trans1.position, Quaternion.identity, transform);

        int m2 = 5;
        Transform trans2 = transform.GetChild(m2).transform;
        Instantiate(barrera2, trans2.position, Quaternion.identity, transform);


    }

}
