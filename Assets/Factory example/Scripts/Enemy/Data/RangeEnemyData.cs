using UnityEngine;

namespace Nevermindever.Enemy.Data
{
    [CreateAssetMenu(fileName = "RangeEnemyData", menuName = "Scriptable Objects/RangeEnemyData")]
    public class RangeEnemyData : EnemyData {
        public float attackCooldown; 
        public GameObject projectilePrefab;
    }
}
