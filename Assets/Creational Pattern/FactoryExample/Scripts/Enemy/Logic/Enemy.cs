using Nevermindever.Factory.Interface;
using UnityEngine;

namespace Nevermindever.Factory.Enemy.Logic {
    public abstract class Enemy {
        protected IDamageable _playerDamageable;
        protected int _damage;
        protected float _speed;
        protected float _fireRate;
        protected Animator _animator;
        protected float _fireRange;
        protected float _escapeRange;
        
        protected Enemy(float speed,int damage, float fireRate, Animator animator, IDamageable playerDamageable,float fireRange,float escapeRange) {
            _speed = speed;
            _damage = damage;
            _fireRate = fireRate;
            _animator = animator;
            _playerDamageable = playerDamageable;
            _fireRange  = fireRate;
            _escapeRange  = fireRate;
            
        }

        public abstract void Attack();
        public abstract void Move(Transform enemy,Transform playerTransform);

    }
}
