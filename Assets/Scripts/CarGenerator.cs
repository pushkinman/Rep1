using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> cars;

    private const float ROAD_STEP = 3.3f;
    private const float SPAWN_DISTANCE = 50f;
    private const float TIME_STEP = 2f;
    private List<Vector3> _spawnPoints = new List<Vector3>();
    private float _time;
    
    // Start is called before the first frame update    
    void Start()
    {
        SetSpawnPoints();
        _time = TIME_STEP;
    }

    private void SetSpawnPoints()
    {
        _spawnPoints.Add(new Vector3(-ROAD_STEP, 0, SPAWN_DISTANCE));
        _spawnPoints.Add(new Vector3(0, 0, SPAWN_DISTANCE));
        _spawnPoints.Add(new Vector3(ROAD_STEP, 0, SPAWN_DISTANCE));
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        if (_time < 0)
        {
            SpawnCar();
            _time = TIME_STEP;
        }
    }

    private void SpawnCar()
    {
        GameObject randomCar = cars[Random.Range(0, cars.Count)];
        Vector3 randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
        Instantiate(randomCar, randomSpawnPoint, Quaternion.identity);
    }
}
