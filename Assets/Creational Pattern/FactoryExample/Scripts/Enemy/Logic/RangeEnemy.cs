using Nevermindever.Factory.Interface;
using UnityEngine;

namespace Nevermindever.Factory.Enemy.Logic {
    public class RangeEnemy : Enemy {
        private float _attackCooldown ;
        private float _lastAttackTime;
        
        public RangeEnemy(float speed, int damage, float fireRate, Animator animator,IDamageable playerDamageable, float escapeRange,float fireRange,float attackCooldown)
            : base(speed, damage, fireRate, animator, playerDamageable, escapeRange, fireRange) {
            _attackCooldown = attackCooldown;
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
