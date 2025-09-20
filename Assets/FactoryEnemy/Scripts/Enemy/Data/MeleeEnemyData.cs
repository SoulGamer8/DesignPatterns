using UnityEngine;

namespace Nevermindever.Enemy.Data {
    [CreateAssetMenu(fileName = "MeleeEnemyData", menuName = "Scriptable Objects/MeleeEnemyData")]
    public class MeleeEnemyData : EnemyData {
        public float attackCooldown ;
        public float fireRange;
        // here you can add some paraterther  what only use in Melee enemy like shield 
    }
}
