using System;
using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using Nevermindever.Interface;
using UnityEngine;
using UnityEngine.TextCore;

namespace Nevermindever.Enemy.Managers {
    public class Spawner : MonoBehaviour {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private IDamageable _playerIDamageable;
        [SerializeField] private EnemyData _enemyData;
        
        private EnemyFactory _factory;

        private void Awake() {
            _factory = new EnemyFactory(_prefab, _playerTransform,_playerIDamageable); 
        }

        public void SpawnEnemy(EnemyData data, Vector3 spawnPosition) {
            //TODO ask pool about object first 
            EnemyComponent enemy = _factory.SpawnEnemy(data,spawnPosition,Quaternion.identity);
            RegisterInObserver(enemy);
        }

        public void SpawnWaveEnemy() {
            
        }
        

        private void RegisterInObserver(EnemyComponent enemy) {
            // Maybe in next article I explain Observer and Object Pool
        }

    }
}
