using System;
using Nevermindever.Interface;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Nevermindever.Player {
    public class PlayerHealth : MonoBehaviour, IDamageable {
        // Yea I know we also can use here code like in Enemy ist absolute better will be I don't make this because its example not about player so in our project don't make like me 
        
        [SerializeField] private int _maxHealth;
        private int _currentHealth;

        public UnityEvent OnDeath;

        private void Awake() {
            _currentHealth = _maxHealth;
        }

        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            if (_currentHealth <= 0)
                OnDeath?.Invoke();
        }

        public void Heal(int heal)
        {
            _currentHealth += heal;
            if (_currentHealth > _maxHealth)
                _currentHealth = _maxHealth;
        }
    }
}