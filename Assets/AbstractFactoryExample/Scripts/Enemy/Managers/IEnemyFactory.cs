using Nevermindever.AbtractFactory.Enemy.Data;
using Nevermindever.Enemy.Logic;
using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Managers {
    public interface  IEnemyFactory {
        public EnemyComponent CreateEnemy(EnemyData data,Vector3 position, Quaternion rotation);
    }
}
