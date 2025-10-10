using Nevermindever.AbstractFactory.Interface;
using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Logic{
    public class NewCoolEnemy:Enemy {
        private int _coolDamage;
        
        public NewCoolEnemy(float speed,int damage, float fireRate, Animator animator, IDamageable playerDamageable,float fireRange,float escapeRange,int coolDamage) 
            : base(speed,damage, fireRate, animator,playerDamageable,fireRange,escapeRange) {
            _coolDamage = coolDamage;
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Move(Transform enemy,Transform playerTransform) {
            if(Vector2.Distance(enemy.position,playerTransform.position)>_fireRange)
                enemy.position = Vector2.MoveTowards(enemy.position,playerTransform.position,_speed *Time.deltaTime);
            else if(Vector2.Distance(enemy.position,playerTransform.position)<_escapeRange)
                enemy.position = Vector2.MoveTowards(enemy.position,playerTransform.position,-(_speed *Time.deltaTime));
        }
    }
}