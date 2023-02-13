using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile3 : MonoBehaviour
{
    GroundSpawner3 groundSpawner3;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstacleChance = 0.2f;

    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner3 = GameObject.FindObjectOfType<GroundSpawner3>();
        //llama por default
        //SpawnObstacle();
        //SpawCoins();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner3.SpawnTile3(true);
        Destroy(gameObject, 2);
    }

    public void SpawnObstacle3()
    {
        //ostauclos altos
        //elegir cual obstaculo aparrece
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f, 1f);
        if (random < tallObstacleChance)
        {
            obstacleToSpawn = tallObstaclePrefab;
        }
        //Generacion obstaculos

        int obstacleSpawnIndex = Random.Range(2, 8);
        Transform spawPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Generar el obtaculo en ese punto
        Instantiate(obstacleToSpawn, spawPoint.position, Quaternion.identity, transform);
        //elegir un punto random
        /* 
         *dificultad extrema
        int obstacleSpawnIndex = Random.Range(2, 4);
        Transform spawPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Generar el obtaculo en ese punto
        Instantiate(obstacleToSpawn, spawPoint.position, Quaternion.identity, transform);

        
        int obstacleSpawnIndex2 = Random.Range(4, 7);
        Transform spawPoint2 = transform.GetChild(obstacleSpawnIndex2).transform;
        //Generar el obtaculo en ese punto
        Instantiate(obstacleToSpawn, spawPoint2.position, Quaternion.identity, transform);

        int obstacleSpawnIndex3 = Random.Range(7, 9);
        Transform spawPoint3 = transform.GetChild(obstacleSpawnIndex3).transform;
        //Generar el obtaculo en ese punto
        Instantiate(obstacleToSpawn, spawPoint3.position, Quaternion.identity, transform);*/
    }

    public void SpawnCoins3()
    {
        int coinsToSpawn = 4;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
