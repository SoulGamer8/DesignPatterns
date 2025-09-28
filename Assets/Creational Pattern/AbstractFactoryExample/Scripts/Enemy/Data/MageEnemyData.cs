using System.Collections.Generic;
using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Data {
    [CreateAssetMenu(fileName = "MageEnemyData", menuName = "Scriptable Objects/AbstractFactory/MageEnemyData")]
    public class MageEnemyData : EnemyData {
        public int maxMana;
        public int manaRegen;
        public List<string> spellList; // its just example
    }
}
