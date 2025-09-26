using System;
using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using Nevermindever.Interface;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Nevermindever.Enemy.AbstractFactory {
    public class MageEnemyFactory : IEnemyFactory {
        private GameObject _prefab;
        private Transform _playerTransform;
        private IDamageable _playerIDamageable;

        public MageEnemyFactory(GameObject prefab, Transform playerTransform, IDamageable playerIDamageable) {
            _prefab = prefab;
            _playerTransform = playerTransform;
            _playerIDamageable = playerIDamageable;
        }
        
        public EnemyComponent CreateEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            GameObject enemyGameObject  = Object.Instantiate(_prefab, position, rotation);
            EnemyComponent enemyComponent = enemyGameObject.GetComponent<EnemyComponent>();
            Health health = new Health(data.health);
            if (data is MageEnemyData mageEnemyData) {
                MageEnemy enemy = new MageEnemy(mageEnemyData.speed,mageEnemyData.damage,mageEnemyData.fireRate,
                    mageEnemyData.animator,_playerIDamageable,mageEnemyData.fireRange,mageEnemyData.escapeRange,mageEnemyData.maxMana,mageEnemyData.manaRegen,mageEnemyData.spellList);
                enemyComponent.Initialize(enemy, health, _playerTransform, mageEnemyData.color);
            }
            else {
                throw new ArgumentException($"Wrong EnemyData type passed: {data.GetType()}");
            }
            return enemyComponent; 
        }
    }
}
