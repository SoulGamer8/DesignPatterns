using Nevermindever.Enemy.Data;
using UnityEngine;

namespace Nevermindever.Enemy.Managers {
    public class EnemyFactory {
        private GameObject _prefab;
        private Transform _playerTransform;
        
        public EnemyFactory(GameObject prefab, Transform playerTransform) {
            _prefab = prefab;
            _playerTransform = playerTransform;
        }
        
        public void CreatEnemy(EnemyData data, Vector3 position, Quaternion rotation) {
            
            
        }
    }
}
