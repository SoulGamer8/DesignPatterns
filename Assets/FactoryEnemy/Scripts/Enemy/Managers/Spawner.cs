using System;
using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using UnityEngine;

namespace Nevermindever.Enemy.Managers
{
    public class Spawner : MonoBehaviour {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private EnemyData _enemyData;


        private void Start()
        {
            
        }


        public void CreatEnemy(EnemyData enemyData) {
            /*switch (enemyData.type)
            {
                case enemyType.Melee:
                    CreatMeleeEnemy(enemyData);
                    break;
                case enemyType.Magic:
                    break;
                case enemyType.Ranged:
                    break;
                default:
                    Debug.Log("Something went wrong");
                    break;
                
            }*/
            
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
            MeleeEnemy enemy = new MeleeEnemy(enemyData.sprite,enemyData.damage,enemyData.health,enemyData.fireRate,
                enemyData.animator,enemyData.fireRange,enemyData.attackCooldown);
            enemyGameObject.GetComponent<EnemyComponent>().Initialize(enemy,_playerTransform);
        }
        
        private void CreatRangeEnemy(RangeEnemyData enemyData) {
            GameObject enemyGameObject  = Instantiate(_prefab, _playerTransform.position, Quaternion.identity);
            RangeEnemy enemy = new RangeEnemy(enemyData.sprite,enemyData.damage,enemyData.health,enemyData.fireRate,
                enemyData.animator,enemyData.firaRange,enemyData.attackCooldown);
            enemyGameObject.GetComponent<EnemyComponent>().Initialize(enemy,_playerTransform);
        }
        
        private void CreatMageEnemy(MageEnemyData enemyData) {
            GameObject enemyGameObject  = Instantiate(_prefab, _playerTransform.position, Quaternion.identity);
            MageEnemy enemy = new MageEnemy(enemyData.sprite,enemyData.damage,enemyData.health,enemyData.fireRate,
                enemyData.animator,enemyData.maxMana,enemyData.manaRegen,enemyData.spellList);
            enemyGameObject.GetComponent<EnemyComponent>().Initialize(enemy,_playerTransform);
        }
    }
}
