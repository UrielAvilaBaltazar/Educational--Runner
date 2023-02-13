using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile2 : MonoBehaviour
{
    GroundSpawner2 groundSpawner;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject coinPrefab;
    //nuevos obstaculos
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstacleChance = 0.2f;

    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner2>();
   
        //llama por default
        //SpawnObstacle();
        //SpawCoins();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile2(true);
        Destroy(gameObject, 2);
    }

    public void SpawnObstacle()
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

        int obstacleSpawnIndex = Random.Range(2, 7);
        Transform spawPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Generar el obtaculo en ese punto
        Instantiate(obstacleToSpawn, spawPoint.position, Quaternion.identity, transform);

    }

    public void SpawnCoins()
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
