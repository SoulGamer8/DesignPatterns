using Nevermindever.Enemy.Data;
using Nevermindever.Enemy.Logic;
using UnityEngine;

namespace Nevermindever.Enemy.AbstractFactory {
    public interface  IEnemyFactory {
        public EnemyComponent CreateEnemy(EnemyData data,Vector3 position, Quaternion rotation);
    }
}
