using Nevermindever.AbstractFactory.Enemy.Data;
using Nevermindever.AbstractFactory.Enemy.Logic;
using Nevermindever.AbstractFactory.Interface;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Nevermindever.AbstractFactory.Enemy.Managers {
    public class Spawner : MonoBehaviour {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _player;
        private EnemyAbstractFactory _enemyAbstractFactory;
        
        private void Awake() {
            IDamageable playerIDamageable = _player.GetComponent<IDamageable>();
            if(playerIDamageable == null)
                Debug.LogWarning("No IDamageable in spawner");
            Transform playerTransform = _player.GetComponent<Transform>();
            if(playerTransform == null)
                Debug.LogWarning("No player transform in spawner");
            _enemyAbstractFactory = new EnemyAbstractFactory();
            _enemyAbstractFactory.RegisterFactory<MeleeEnemyData>(new MeleeEnemyFactory(_prefab, playerTransform, playerIDamageable));
            _enemyAbstractFactory.RegisterFactory<RangeEnemyData>(new RangeEnemyFactory(_prefab, playerTransform, playerIDamageable));
            _enemyAbstractFactory.RegisterFactory<MageEnemyData>(new MageEnemyFactory(_prefab, playerTransform, playerIDamageable));
        }
        
        public void SpawnEnemyAtRandomPosition(EnemyData data) {
            Vector2 randomSpawnPosition = new Vector2(
                Random.Range(-8f, 8),
                Random.Range(-5f, 5));
            SpawnEnemy(data, randomSpawnPosition);
        }
        
        public void SpawnEnemy(EnemyData data,Vector2 spawnoPosition) {
            //TODO ask pool about object first 
            EnemyComponent enemy = _enemyAbstractFactory.CreateEnemy(data,spawnoPosition,Quaternion.identity);
            RegisterInObserver(enemy);
        }

        public void SpawnWaveEnemy() {
            
        }
        

        private void RegisterInObserver(EnemyComponent enemy) {
            // Maybe in next article I explain Observer and Object Pool
        }

    }
}
