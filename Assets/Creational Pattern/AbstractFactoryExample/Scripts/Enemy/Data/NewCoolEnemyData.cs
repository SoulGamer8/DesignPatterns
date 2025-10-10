using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Data {
    [CreateAssetMenu(fileName = "NewCoolEnemyData", menuName = "Scriptable Objects/AbstractFactory/NewCoolEnemyData")]
    public class NewCoolEnemyData : EnemyData {
        public int coolDamage;
    }
}
