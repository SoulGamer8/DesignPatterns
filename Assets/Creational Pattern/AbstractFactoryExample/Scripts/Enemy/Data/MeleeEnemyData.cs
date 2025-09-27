using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Data {
    [CreateAssetMenu(fileName = "MeleeEnemyData", menuName = "Scriptable Objects/MeleeEnemyData")]
    public class MeleeEnemyData : EnemyData {
        public float attackCooldown ;
        // here you can add some things that only use in Melee enemy like shield
    }
}
