using System;
using Nevermindever.AbstractFactory.Enemy.Data;
using Nevermindever.AbstractFactory.Enemy.Logic;
using Nevermindever.AbstractFactory.Interface;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Nevermindever.AbstractFactory.Enemy.Managers {
    public class RangeEnemyFactory : IEnemyFactory {
        private GameObject _prefab;
        private Transform _playerTransform;
        private IDamageable _playerIDamageable;
        
        public RangeEnemyFactory(GameObject prefab, Transform playerTransform, IDamageable playerIDamageable) {
            _prefab = prefab;
            _playerTransform = playerTransform;
            _playerIDamageable = playerIDamageable;
        }
        
        public EnemyComponent CreateEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            GameObject enemyGameObject  = Object.Instantiate(_prefab, position, rotation);
            EnemyComponent enemyComponent = enemyGameObject.GetComponent<EnemyComponent>();
            Health health = new Health(data.health);
            if (data is RangeEnemyData rangeEnemyData) {
                RangeEnemy enemy = new RangeEnemy(rangeEnemyData.speed,rangeEnemyData.damage,rangeEnemyData.fireRate,
                rangeEnemyData.animator,_playerIDamageable,rangeEnemyData.escapeRange,rangeEnemyData.fireRange,rangeEnemyData.attackCooldown);
                enemyComponent.Initialize(enemy, health, _playerTransform, rangeEnemyData.color);
            }
            else {
                throw new ArgumentException($"Wrong EnemyData type passed: {data.GetType()}");
            }
            return enemyComponent; 
        }
    }
}
