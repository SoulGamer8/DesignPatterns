using System.Collections.Generic;
using Nevermindever.Interface;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    public class MageEnemy:Enemy {
        private int _maxMana;
        private int _manaRegen;
        private List<string> _spellList;
        
        public MageEnemy(int damage, float fireRate, Animator animator, Transform playerTransform, IDamageable playerDamageable,int maxMana,int manaRegen,List<string> spellList) 
            : base( damage, fireRate, animator,playerTransform,playerDamageable) {
            _maxMana = maxMana;
            _manaRegen = manaRegen;
            _spellList = spellList; 
        }

        public override void Attack() {
            //Here you can make your attack for this type enemy  and use playerDamageable for damage player
        }

        public override void Move() {
            //Here write how this type enemy would be move 
        }
    }
}