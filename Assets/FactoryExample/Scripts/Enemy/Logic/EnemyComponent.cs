using System;
using Nevermindever.Interface;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    [RequireComponent(typeof(SpriteRenderer))]
    public class EnemyComponent : MonoBehaviour, IDamageable {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        private Transform _playerTransform;
        private Enemy _enemy;
        private Health _health;
        
        public void Initialize(Enemy enemy,Health health,Transform playerTransform, Color color) {
            _enemy = enemy;
            _health = health;
            _playerTransform = playerTransform;
            _health.OnDeath += Death;
            SetupVisual(color);
        }
        
        private void SetupVisual(Color color) {
            _spriteRenderer.color = color;
        }

        private void Update() {
            _enemy.Move(gameObject.transform,_playerTransform);
        }
        
        public void TakeDamage(int damage) {
            _health.TakeDamage(damage);
        }
        
        private void Death() {
            _health.OnDeath -= Death;
            //TODO Add animation and some cool VFX and SFX    
        }
        
    }
}
