using System.Collections.Generic;
using Nevermindever.Factory.Interface;
using UnityEngine;

namespace Nevermindever.Factory.Enemy.Logic {
    public class MageEnemy:Enemy {
        private int _maxMana;
        private int _manaRegen;
        private List<string> _spellList;
        
        public MageEnemy(float speed,int damage, float fireRate, Animator animator, IDamageable playerDamageable,float fireRange,float escapeRange,int maxMana,int manaRegen,List<string> spellList) 
            : base(speed,damage, fireRate, animator,playerDamageable,fireRange,escapeRange) {
            _maxMana = maxMana;
            _manaRegen = manaRegen;
            _spellList = spellList; 
        }

        public override void Attack() {
            //Here you can make your attack for this type enemy  and use playerDamageable for damage player
        }

        public override void Move(Transform enemy,Transform playerTransform) {
            if(Vector2.Distance(enemy.position,playerTransform.position)>_fireRange)
                enemy.position = Vector2.MoveTowards(enemy.position,playerTransform.position,_speed *Time.deltaTime);
            else if(Vector2.Distance(enemy.position,playerTransform.position)<_escapeRange)
                enemy.position = Vector2.MoveTowards(enemy.position,playerTransform.position,-(_speed *Time.deltaTime));
        }
    }
}