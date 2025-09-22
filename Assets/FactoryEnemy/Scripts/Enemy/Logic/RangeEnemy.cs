using Nevermindever.Interface;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    public class RangeEnemy : Enemy {
        private float _fireRange;
        private float _attackCooldown ;
        private float _lastAttackTime;
        
        public RangeEnemy( int damage, float fireRate, Animator animator,IDamageable playerDamageable, float fireRange,float attackCooldown)
            : base(damage, fireRate, animator,playerDamageable) {
            _fireRange = fireRange;
            _attackCooldown = attackCooldown;
        }
        public override void Attack() {
            //Here you can make your attack for this type enemy  and use playerDamageable for damage player
        }

        public override void Move(Transform playerTransform) {
            //Here write how this type enemy would be move 
        }
    }
}
