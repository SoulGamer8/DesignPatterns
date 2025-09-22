using Nevermindever.Interface;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    public abstract class Enemy {
        private Transform _playerTransform;
        private IDamageable _playerDamageable;
        private int _damage;
        private float _fireRate;
        private Animator _animator;

        
        protected Enemy(int damage, float fireRate, Animator animator, IDamageable playerDamageable) {
            _damage = damage;
            _fireRate = fireRate;
            _animator = animator;
            _playerDamageable = playerDamageable;
        }

        public abstract void Attack();
        public abstract void Move(Transform playerTransform);

    }
}
