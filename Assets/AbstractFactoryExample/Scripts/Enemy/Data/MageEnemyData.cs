using System.Collections.Generic;
using UnityEngine;

namespace Nevermindever.AbtractFactory.Enemy.Data {
    [CreateAssetMenu(fileName = "MageEnemyData", menuName = "Scriptable Objects/MageEnemyData")]
    public class MageEnemyData : EnemyData {
        public int maxMana;
        public int manaRegen;
        public List<string> spellList; // its just example
    }
}
