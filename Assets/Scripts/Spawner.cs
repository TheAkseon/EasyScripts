using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private GameObject _prefab;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    private void Update()
    {
        Instantiate(_prefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform.position, Quaternion.identity);
    }
}
