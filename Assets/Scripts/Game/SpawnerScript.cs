using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefabs;
    public float obstacleSpawnTime = 2f;
    public float enemySpeed = 1f;

    public float timeUntilEnemySpawn;


    private void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        timeUntilEnemySpawn += Time.deltaTime;

        if (timeUntilEnemySpawn >= obstacleSpawnTime)
        {
            Spawn();
            timeUntilEnemySpawn = 0f;
        }
    }

    private void Spawn()
    {
        GameObject ObstacleToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

        GameObject spawnedObstacle = Instantiate(ObstacleToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D obstacleRB = spawnedObstacle.GetComponent<Rigidbody2D>();
        obstacleRB.linearVelocity = Vector2.left * enemySpeed;

    }

}

