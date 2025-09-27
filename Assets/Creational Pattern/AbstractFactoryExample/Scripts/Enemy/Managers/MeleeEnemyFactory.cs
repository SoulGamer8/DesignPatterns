using System;
using Nevermindever.AbstractFactory.Enemy.Data;
using Nevermindever.AbstractFactory.Enemy.Logic;
using Nevermindever.AbstractFactory.Interface;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Nevermindever.AbstractFactory.Enemy.Managers {
    public class MeleeEnemyFactory : IEnemyFactory {
        private GameObject _prefab;
        private Transform _playerTransform;
        private IDamageable _playerIDamageable;
        
        public MeleeEnemyFactory(GameObject prefab, Transform playerTransform, IDamageable playerIDamageable) {
            _prefab = prefab;
            _playerTransform = playerTransform;
            _playerIDamageable = playerIDamageable;
        }
        
        public EnemyComponent CreateEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            GameObject enemyGameObject  = Object.Instantiate(_prefab, position, rotation);
            EnemyComponent enemyComponent = enemyGameObject.GetComponent<EnemyComponent>();
            Health health = new Health(data.health);
            if (data is MeleeEnemyData meleeData) {
                MeleeEnemy enemy = new MeleeEnemy(meleeData.speed, meleeData.damage, meleeData.fireRate, meleeData.animator,
                    _playerIDamageable, meleeData.escapeRange, meleeData.fireRange, meleeData.attackCooldown
                );
                enemyComponent.Initialize(enemy, health, _playerTransform, meleeData.color);
            }
            else {
                throw new ArgumentException($"Wrong EnemyData type passed: {data.GetType()}");
            }
            return enemyComponent; 
        }
    }
}
 