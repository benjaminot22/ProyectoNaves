using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [Header("Prefabs a Spawnear")]
    public GameObject[] prefabsToSpawn;

    [Header("Configuración de Tiempo")]
    public float spawnInterval = 1.5f;  
    private float timer;

    [Header("Coordenadas de Spawn")]
    public float minX = -6f;           
    public float maxX = 6f;            
    public float spawnY = 2f;          

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        if (prefabsToSpawn.Length == 0) return;

        int randomIndex = Random.Range(0, prefabsToSpawn.Length);
        GameObject selectedPrefab = prefabsToSpawn[randomIndex];

        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

        Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
    }
}