using System;
using Nevermindever.Interface;
using UnityEngine;

namespace Nevermindever.Enemy.Logic {
    [RequireComponent(typeof(SpriteRenderer))]
    public class EnemyComponent : MonoBehaviour, IDamagable {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        private Transform _playerTransform;
        private Enemy _enemy;
        
        public void Initialize(Enemy enemy,Transform playerTransform) {
            _enemy = enemy;
            _playerTransform = playerTransform;
            SetupVisual();
        }

        private void Update() {
            MoveToPlayer();
        }

        private void MoveToPlayer() {
            transform.position =  Vector2.MoveTowards(transform.position, _playerTransform.position,5 * Time.deltaTime);
        }

        private void SetupVisual() {
            _spriteRenderer.sprite = _enemy.Sprite;
        }

        public void TakeDamage(int damage) {
            _enemy.TakeDamage(damage);
        }
        
        
    }
}
