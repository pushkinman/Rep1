using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private GameObject roadTile;
    [SerializeField] private Vector3 startRoadTilePosition = new Vector3(0,0,50);
    [SerializeField] private Vector3 finishRoadTilePosition = new Vector3(0,0,-10);
    [SerializeField] private int numberOfStartingTiles = 5;
    [SerializeField] private float tileSpeed = 0.3f;
    

    private List<GameObject> _roadTiles;

    // Start is called before the first frame update
    void Start()
    {
        _roadTiles = new List<GameObject>();
        RoadTileMovement.speed = tileSpeed;
        SpawnInitialRoadTiles();
    }

    private void SpawnInitialRoadTiles()
    {
        for (int i = 0; i < (numberOfStartingTiles * 10); i += 10)
        {
            GameObject tile = Instantiate(roadTile, new Vector3(0, 0, i), Quaternion.identity);
            _roadTiles.Add(tile);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckRoadTile();
        CheckUserInput();
    }

    private void CheckUserInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseSpeed();
        }
    }

    private void IncreaseSpeed()
    {
        RoadTileMovement.speed *= 2;
    }

    private void CheckRoadTile()
    {
        if (_roadTiles == null || _roadTiles.Count == 0)
        {
            return;
        }

        int numberOfTiles = _roadTiles.Count;
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (_roadTiles[i].transform.position.z <= finishRoadTilePosition.z + RoadTileMovement.speed)
            {
                Destroy(_roadTiles[i]);
                _roadTiles.Remove(_roadTiles[i]);
                GameObject newTile = Instantiate(roadTile, startRoadTilePosition, Quaternion.identity);
                _roadTiles.Add(newTile);
            }
        }
    }
}
