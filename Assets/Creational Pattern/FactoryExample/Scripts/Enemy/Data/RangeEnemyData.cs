using UnityEngine;

namespace Nevermindever.Factory.Enemy.Data {
    [CreateAssetMenu(fileName = "RangeEnemyData", menuName = "Scriptable Objects/RangeEnemyData")]
    public class RangeEnemyData : EnemyData {
        public float attackCooldown; 
        public GameObject projectilePrefab;
    }
}
