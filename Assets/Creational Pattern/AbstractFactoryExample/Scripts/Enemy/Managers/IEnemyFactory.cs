using Nevermindever.AbstractFactory.Enemy.Data;
using Nevermindever.AbstractFactory.Enemy.Logic;
using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Managers {
    public interface  IEnemyFactory {
        public EnemyComponent CreateEnemy(EnemyData data,Vector3 position, Quaternion rotation);
    }
}
