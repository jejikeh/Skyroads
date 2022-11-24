using System.Collections.Generic;
using UnityEngine;

namespace Source.Spawners
{
    public class AsteroidSpawner : MonoBehaviour
    {
        [SerializeField] private Vector3 _offset;
        [SerializeField] private Vector3 _spawnField;
        [SerializeField] private GameObject _asteroidPrefab;
        private List<GameObject> _spawnedAsteroid = new List<GameObject>();

        public void Spawn(SpawnerManager spawnerManager)
        {
            Instantiate(_asteroidPrefab, (transform.forward * spawnerManager.SpawnOffset) + GetRandomVector3() + _offset + transform.position, transform.rotation);
        }

        private Vector3 GetRandomVector3()
        {
            return new Vector3(
                Random.Range(-_spawnField.x, _spawnField.x),
                Random.Range(-_spawnField.y, _spawnField.y),
                0);
        }
    }
}