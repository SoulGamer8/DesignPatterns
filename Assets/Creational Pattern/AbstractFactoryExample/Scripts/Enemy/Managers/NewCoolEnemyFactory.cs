using System;
using Nevermindever.AbstractFactory.Enemy.Data;
using Nevermindever.AbstractFactory.Enemy.Logic;
using Nevermindever.AbstractFactory.Interface;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Nevermindever.AbstractFactory.Enemy.Managers
{
    public class NewCoolEnemyFactory : IEnemyFactory
    {
        private GameObject _prefab;
        private Transform _playerTransform;
        private IDamageable _playerIDamageable;
        
        public NewCoolEnemyFactory(GameObject prefab, Transform playerTransform, IDamageable playerIDamageable) {
            _prefab = prefab;
            _playerTransform = playerTransform;
            _playerIDamageable = playerIDamageable;
        }
        
        public EnemyComponent CreateEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            GameObject enemyGameObject  = Object.Instantiate(_prefab, position, rotation);
            EnemyComponent enemyComponent = enemyGameObject.GetComponent<EnemyComponent>();
            Health health = new Health(data.health);
            if (data is NewCoolEnemyData newCoolEnemyData) {
                NewCoolEnemy enemy = new NewCoolEnemy(newCoolEnemyData.speed, newCoolEnemyData.damage, newCoolEnemyData.fireRate, newCoolEnemyData.animator,
                    _playerIDamageable, newCoolEnemyData.fireRange, newCoolEnemyData.escapeRange, newCoolEnemyData.coolDamage
                );
                enemyComponent.Initialize(enemy, health, _playerTransform, newCoolEnemyData.color);
            }
            else {
                throw new ArgumentException($"Wrong EnemyData type passed: {data.GetType()}");
            }
            return enemyComponent; 
        }
    }
}
