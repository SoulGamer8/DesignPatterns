using System;
using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using UnityEngine;

namespace Nevermindever.Enemy.Managers {
    public class Spawner : MonoBehaviour {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private EnemyData _enemyData;


        private void Start() {
            CreatEnemy(_enemyData);
        }


        public void CreatEnemy(EnemyData enemyData) {
            //TODO Ask object pool first 
            
            switch (enemyData) {
                case MeleeEnemyData meleeData:
                    CreatMeleeEnemy(meleeData);
                    break;
                case MageEnemyData magicData:
                    CreatMageEnemy(magicData);
                    break;
                case RangeEnemyData rangedData:
                    CreatRangeEnemy(rangedData);
                    break;
                default:
                    Debug.LogError("Unknown enemy type");
                    break;
            }
        }
            

        private void CreatMeleeEnemy(MeleeEnemyData enemyData) {
            GameObject enemyGameObject  = Instantiate(_prefab, _playerTransform.position, Quaternion.identity);
            MeleeEnemy enemy = new MeleeEnemy(enemyData.damage,enemyData.fireRate,
                enemyData.animator,enemyData.fireRange,enemyData.attackCooldown);
            //TODO Register in Observer
            enemyGameObject.GetComponent<EnemyComponent>().Initialize(enemy,_playerTransform,enemyData.sprite);
        }
        
        private void CreatRangeEnemy(RangeEnemyData enemyData) {
            GameObject enemyGameObject  = Instantiate(_prefab, _playerTransform.position, Quaternion.identity);
            RangeEnemy enemy = new RangeEnemy(enemyData.damage,enemyData.fireRate,
                enemyData.animator,enemyData.firaRange,enemyData.attackCooldown);
            //TODO Add projectile fabric 
            //TODO Register in Observer
            enemyGameObject.GetComponent<EnemyComponent>().Initialize(enemy,_playerTransform,enemyData.sprite);
        }
        
        private void CreatMageEnemy(MageEnemyData enemyData) {
            GameObject enemyGameObject  = Instantiate(_prefab, _playerTransform.position, Quaternion.identity);
            MageEnemy enemy = new MageEnemy(enemyData.damage,enemyData.fireRate,
                enemyData.animator,enemyData.maxMana,enemyData.manaRegen,enemyData.spellList);
            //TODO CreatSpell List 
            //TODO Register in Observer
            enemyGameObject.GetComponent<EnemyComponent>().Initialize(enemy,_playerTransform,enemyData.sprite);
        }
    }
}
