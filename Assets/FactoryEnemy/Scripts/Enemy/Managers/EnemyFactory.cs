using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using Nevermindever.Interface;
using UnityEngine;

namespace Nevermindever.Enemy.Managers {
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
            GameObject enemyGameObject  = Object.Instantiate(_prefab, _playerTransform.position, Quaternion.identity);
            EnemyComponent enemyComponent = enemyGameObject.GetComponent<EnemyComponent>();
            Health health = new Health(data.health);
            Logic.Enemy enemy = null;
            switch (data) {
                case MeleeEnemyData meleeData:
                    enemy= CreatMeleeEnemy(meleeData);
                    break;
                case MageEnemyData magicData:
                    enemy = CreatMageEnemy(magicData);
                    break;
                case RangeEnemyData rangedData:
                    enemy =  CreatRangeEnemy(rangedData);
                    break;
                default:
                    Debug.LogError("Unknown enemy type");
                    break;
            }
            enemyComponent.Initialize(enemy,health,_playerTransform,data.sprite);
            return enemyComponent; 
        }
            

        private MeleeEnemy CreatMeleeEnemy(MeleeEnemyData enemyData) {
            MeleeEnemy enemy = new MeleeEnemy(enemyData.damage,enemyData.fireRate,
                enemyData.animator,_playerIDamageable,enemyData.fireRange,enemyData.attackCooldown);
            return enemy;
        }
        
        private RangeEnemy CreatRangeEnemy(RangeEnemyData enemyData) {
            RangeEnemy enemy = new RangeEnemy(enemyData.damage,enemyData.fireRate,
                enemyData.animator,_playerIDamageable,enemyData.firaRange,enemyData.attackCooldown);
            return enemy;
        }
        
        private MageEnemy CreatMageEnemy(MageEnemyData enemyData) {
            MageEnemy enemy = new MageEnemy(enemyData.damage,enemyData.fireRate,
                enemyData.animator,_playerIDamageable,enemyData.maxMana,enemyData.manaRegen,enemyData.spellList);
            return enemy;
        }
    }
}
