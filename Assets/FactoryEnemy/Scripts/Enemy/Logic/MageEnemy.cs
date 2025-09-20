using System.Collections.Generic;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    public class MageEnemy:Enemy {
        private int _maxMana;
        private int _manaRegen;
        private List<string> _spellList;
        
        public MageEnemy(Sprite sprite, int damage, int health, float fireRate, Animator animator,int maxMana,int manaRegen,List<string> spellList) 
            : base(sprite, damage, health, fireRate, animator) {
            _maxMana = maxMana;
            _manaRegen = manaRegen;
            _spellList = spellList; 
        }
        
    }
}