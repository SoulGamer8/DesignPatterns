using Nevermindever.Factory.Enemy.Data;
using Nevermindever.Factory.Enemy.Logic;
using Nevermindever.Factory.Interface;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Nevermindever.Factory.Enemy.Managers {
    public class EnemyFactory {
        private GameObject _prefab;
        private Transform _playerTransform;
        private IDamageable _playerIDamageable;
        
        public EnemyFactory(GameObject prefab, Transform playerTransform, IDamageable playerIDamageable) {
            _prefab = prefab;
            _playerTransform = playerTransform;
            _playerIDamageable = playerIDamageable;
        }
        
        public EnemyComponent SpawnEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            GameObject enemyGameObject  = Object.Instantiate(_prefab, position, Quaternion.identity);
            EnemyComponent enemyComponent = enemyGameObject.GetComponent<EnemyComponent>();
            Health health = new Health(data.health);
            Logic.Enemy enemy = null;
            switch (data) {
                case MeleeEnemyData meleeData:
                    enemy= CreateMeleeEnemy(meleeData);
                    break;
                case MageEnemyData magicData:
                    enemy = CreateMageEnemy(magicData);
                    break;
                case RangeEnemyData rangedData:
                    enemy =  CreateRangeEnemy(rangedData);
                    break;
                default:
                    Debug.LogError("Unknown enemy type");
                    break;
            }
            enemyComponent.Initialize(enemy,health,_playerTransform,data.color);
            return enemyComponent; 
        }
            

        private MeleeEnemy CreateMeleeEnemy(MeleeEnemyData enemyData) {
            return new MeleeEnemy(enemyData.speed,enemyData.damage,enemyData.fireRate,
                enemyData.animator,_playerIDamageable,enemyData.fireRange,enemyData.escapeRange,enemyData.attackCooldown);
        }
        
        private RangeEnemy CreateRangeEnemy(RangeEnemyData enemyData) {
            return new RangeEnemy(enemyData.speed,enemyData.damage,enemyData.fireRate,
                enemyData.animator,_playerIDamageable,enemyData.fireRange,enemyData.escapeRange,enemyData.attackCooldown);
        }
        
        private MageEnemy CreateMageEnemy(MageEnemyData enemyData) {
            return  new MageEnemy(enemyData.speed,enemyData.damage,enemyData.fireRate,
                enemyData.animator,_playerIDamageable,enemyData.fireRange,enemyData.escapeRange,enemyData.maxMana,enemyData.manaRegen,enemyData.spellList);
        }
    }
}
