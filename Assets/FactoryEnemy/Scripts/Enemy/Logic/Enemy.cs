using System;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    public class Enemy {
        public Sprite Sprite{get; private set;}
        private int _damage;
        private int _health;
        private float _fireRate;
        private Animator _animator;

        public event Action OnDeath;
        
        protected Enemy(Sprite sprite, int damage,int health, float fireRate, Animator animator) {
            Sprite = sprite;
            _damage = damage;
            _health = health;
            _fireRate = fireRate;
            _animator = animator;
            OnDeath += Death;
        }
        
        public void TakeDamage(int damage) {
            _health -= damage;
            if (_health <= 0) 
                OnDeath?.Invoke();
            
        }

        public void DealDamage(int damage) {
            
        }

        private void Death() {
            // here you can use you animation
        }
        
    }
}
