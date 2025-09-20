using UnityEngine;

namespace Nevermindever.Enemy.Logic
{
    public class RangeEnemy : Enemy {
        private float _fireRange;
        private float _attackCooldown ;
        private float _lastAttackTime;
        
        public RangeEnemy(Sprite sprite, int damage, int health, float fireRate, Animator animator,float fireRange,float attackCooldown)
            : base(sprite, damage, health, fireRate, animator) {
            _fireRange = fireRange;
            _attackCooldown = attackCooldown;
        }
        
        public bool CanAttack() {
            return Time.time - _lastAttackTime >= _attackCooldown;
        }
    
        public void PerformAttack() {
            if (!CanAttack()) return;
        
            _lastAttackTime = Time.time;
        }
    }
}
