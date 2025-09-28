using UnityEngine;

namespace Nevermindever.Factory.Enemy.Data {
    [CreateAssetMenu(fileName = "MeleeEnemyData", menuName = "Scriptable Objects/Factory/MeleeEnemyData")]
    public class MeleeEnemyData : EnemyData {
        public float attackCooldown ;
        // here you can add some things that only use in Melee enemy like shield
    }
}
