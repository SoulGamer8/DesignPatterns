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
        
        public void Initialize(Enemy enemy,Transform playerTransform, Sprite sprite) {
            _enemy = enemy;
            _playerTransform = playerTransform;
            _health.OnDeath += Death;
            SetupVisual(sprite);
        }
        
        private void SetupVisual(Sprite sprite) {
            _spriteRenderer.sprite = sprite;
        }

        private void Update() {
            _enemy.Move();
        }
        
        public void TakeDamage(int damage) {
            _health.TakeDamage(damage);
        }
        
        private void Death() {
            //TODO Add animation and some cool VFX and SFX    
        }
        
    }
}
