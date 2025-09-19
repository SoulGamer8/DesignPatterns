using UnityEngine;

namespace Nevermindever.Enemy.Data
{
    [CreateAssetMenu(fileName = "RangeEnemyData", menuName = "Scriptable Objects/RangeEnemyData")]
    public class RangeEnemyData : ScriptableObject {
        public float firaRange;
        public GameObject projectilePrefab;
        public enemyType type = enemyType.Ranged;
        
    }
}
