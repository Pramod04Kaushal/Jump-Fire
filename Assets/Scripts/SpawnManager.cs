using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0.49f, -6.23f);
    private float startDelay = 2;
    private float repeat = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeat);
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
