using Nevermindever.AbstractFactory.Interface;
using UnityEngine;

namespace Nevermindever.AbstractFactory.Enemy.Logic {
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
            _fireRange  = fireRange;
            _escapeRange  = escapeRange;
            
        }

        public abstract void Attack();
        public abstract void Move(Transform enemy,Transform playerTransform);

    }
}
