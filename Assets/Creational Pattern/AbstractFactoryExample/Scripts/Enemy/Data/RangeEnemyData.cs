using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Data
{
    [CreateAssetMenu(fileName = "RangeEnemyData", menuName = "Scriptable Objects/AbstractFactory/RangeEnemyData")]
    public class RangeEnemyData : EnemyData {
        public float attackCooldown; 
        public GameObject projectilePrefab;
    }
}
