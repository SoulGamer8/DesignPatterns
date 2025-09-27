using System;
using Nevermindever.Factory.Enemy.Data;
using Nevermindever.Factory.Enemy.Logic;
using Nevermindever.Factory.Interface;
using UnityEngine;
using UnityEngine.TextCore;
using Random = UnityEngine.Random;

namespace Nevermindever.Factory.Enemy.Managers {
    public class Spawner : MonoBehaviour {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _player;
        
        
        
        private EnemyFactory _factory;

        private void Awake() {
            IDamageable playerIDamageable = _player.GetComponent<IDamageable>();
            if(playerIDamageable == null)
                Debug.LogWarning("No IDamageable in spawner");
            Transform playerTransform = _player.GetComponent<Transform>();
            if(playerTransform == null)
                Debug.LogWarning("No player transform in spawner");
            _factory = new EnemyFactory(_prefab, playerTransform,playerIDamageable); 
        }

        public void SpawnEnemyAtRandomPosition(EnemyData data) {
            Vector2 randomSpawnPosition = new Vector2(
                Random.Range(-8f, 8),
                Random.Range(-5f, 5));
            SpawnEnemy(data, randomSpawnPosition);
        }
        
        public void SpawnEnemy(EnemyData data,Vector2 spawnoPosition) {
            //TODO ask pool about object first 
            EnemyComponent enemy = _factory.SpawnEnemy(data,spawnoPosition,Quaternion.identity);
            RegisterInObserver(enemy);
        }

        public void SpawnWaveEnemy() {
            
        }
        

        private void RegisterInObserver(EnemyComponent enemy) {
            // Maybe in next article I explain Observer and Object Pool
        }

    }
}
